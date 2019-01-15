using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using URG.Library;

namespace URG_VirtualTouchPad {
    public partial class Form1 : Form {
        Thread runner = null;
        bool bindMouse = false;
        Hokuyo hokuyo = null;
        int screenWidth;
        int screenHeight;
        public Form1() {
            InitializeComponent();
        }

        #region 校正值設定
        private void offsetX_Control_Scroll(object sender, EventArgs e) {
            OffsetX_Label.Text = offsetX_Control.Value + "px";
        }

        private void offsetY_Control_Scroll(object sender, EventArgs e) {
            OffsetY_Label.Text = offsetY_Control.Value + "px";
        }
        private void offsetX2_Control_Scroll(object sender, EventArgs e) {
            OffsetX2_Label.Text = offsetX2_Control.Value + "px";
        }

        private void offsetY2_Control_Scroll(object sender, EventArgs e) {
            OffsetY2_Label.Text = offsetY2_Control.Value + "px";
        }
        private void offsetX3_Control_Scroll(object sender, EventArgs e) {
            OffsetX3_Label.Text = offsetX3_Control.Value + "px";
        }

        private void offsetY3_Control_Scroll(object sender, EventArgs e) {
            OffsetY3_Label.Text = offsetY3_Control.Value + "px";
        }
        #endregion

        private void StartButton_Click(object sender, EventArgs e) {
            if (runner != null) {
                runner = null;

                MinX.Enabled = true;
                MinY.Enabled = true;
                MaxX.Enabled = true;
                MaxY.Enabled = true;

                groupBox2.Enabled = false;
                groupBox3.Enabled = false;

                StartButton.Text = "開始";

                WriteLog("I,停止運行");
            } else {
                runner = new Thread(new ThreadStart(runnerContext));
                runner.Start();

                MinX.Enabled = false;
                MinY.Enabled = false;
                MaxX.Enabled = false;
                MaxY.Enabled = false;

                groupBox2.Enabled = true;
                groupBox3.Enabled = true;

                StartButton.Text = "停止";

                Log.Clear();
                WriteLog("I,開始運行");
            }
        }

        public void WriteLog(string text) {
            this.Invoke((MethodInvoker)delegate () {
                Log.Text += text + Environment.NewLine;


                Log.SelectionStart = Log.TextLength;
                Log.ScrollToCaret();
            });
        }

        private void BindMouseButton_Click(object sender, EventArgs e) {
            bindMouse = !bindMouse;

            if (bindMouse) {
                BindMouseButton.Text = "停用滑鼠連動";
                WriteLog("I,起用滑鼠連動");
            } else {
                BindMouseButton.Text = "啟用滑鼠連動";
                WriteLog("I,停用滑鼠連動");
            }
        }



        public void runnerContext() {
            var connectionInfo = GetDeviceConnectionInfo();
            if (connectionInfo.comPort == 0) {
                WriteLog("E,Device Not Found");

                return;
            } else {
                WriteLog($"I,COM Port={connectionInfo.comPort}");
                WriteLog($"I,Baud Rate={connectionInfo.baudRate}");
            }

            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;

            WriteLog($"I,Screen Size={screenWidth}*{screenHeight}");

            hokuyo = new Hokuyo(connectionInfo.comPort, connectionInfo.baudRate);
            hokuyo.Connect();

            int buffer = 0;
            List<(double x, double y)> bufferPosition = new List<(double x, double y)>();
            while (true) {
                if (runner == null) break;
                buffer++;
                try {
                    var rawDistanceValues = hokuyo.GetData();
                    var rawPoints = rawDistanceValues
                            .Skip(128 - 44).Take(384 - 128)
                            .Select((x, i) => new {
                                degree = i * ((Math.PI / 2) / (384 - 128)),
                                distance = x
                            })
                            .Select(x => GetPoint(x.degree, x.distance))
                            .Where(x =>
                                x.x >= decimal.ToInt32(MinX.Value) && x.x <= decimal.ToInt32(MaxX.Value) &&
                                x.y >= decimal.ToInt32(MinY.Value) && x.y <= decimal.ToInt32(MaxY.Value));

                    var currentPoint = (
                        x: rawPoints.Sum(x => x.x) / rawPoints.Count(),
                        y: rawPoints.Sum(x => x.y) / rawPoints.Count()
                    );

                    if (double.IsNaN(currentPoint.x) ||
                       double.IsNaN(currentPoint.y)) {
                        continue;
                    }

                    currentPoint = ConvertPosition(currentPoint);
                    bufferPosition.Add(currentPoint); // 加入緩衝

                    if (buffer % Convert.ToInt32(BufferCount.Value) == 0) {
                        // 達到緩衝次數
                        buffer = 0;

                        // 計算平均值
                        currentPoint = (x: bufferPosition.Average(x => x.x), y: bufferPosition.Average(x => x.y));

                        bufferPosition.Clear();
                    } else {
                        // 緩衝中跳過
                        continue;
                    }

                    if (bindMouse) {
                        WinAPI.SetCursorPos((int)currentPoint.x, (int)currentPoint.y);

                        bool autoClick = false;
                        this.Invoke((MethodInvoker)delegate () {
                            autoClick = AutoClickCheckBox.Checked;
                        });

                        if (autoClick) {
                            WinAPI.mouse_event(WinAPI.MOUSEEVENTF_LEFTDOWN, (int)currentPoint.x, (int)currentPoint.y, 0, 0);
                            WinAPI.mouse_event(WinAPI.MOUSEEVENTF_LEFTUP, (int)currentPoint.x, (int)currentPoint.y, 0, 0);
                        }
                    }

                    WriteLog($"I,x: {currentPoint.x}, y: {currentPoint.y}");
                } catch (Exception e) {
                    WriteLog("E," + e.ToString());
                }
            }

            hokuyo.Disconnect();
            hokuyo = null;
        }




        /// <summary>
        /// 取得測距裝置COM PORT以及BaudRate值
        /// </summary>
        /// <returns></returns>
        public static (int comPort, int baudRate) GetDeviceConnectionInfo() {
            ManagementObjectCollection ManObjReturn;
            ManagementObjectSearcher ManObjSearch;
            ManObjSearch = new ManagementObjectSearcher("Select * from Win32_SerialPort");
            ManObjReturn = ManObjSearch.Get();

            int i = 1;
            foreach (ManagementObject ManObj in ManObjReturn) {
                var d = "";
                foreach (var po in ManObj.Properties) {
                    d += po.Name + ":" + po.Value + "\r\n";
                }
                if (ManObj["PNPDeviceID"].ToString().StartsWith(@"USB\VID_15D1&PID_0000")) {
                    return (int.Parse(ManObj["DeviceID"].ToString().Substring(3)),
                        int.Parse((ManObj["MaxBaudRate"] ?? "115200").ToString()));
                }
                i++;
            }

            return (0, 0);
        }


        /// <summary>
        /// 使用弧度與距離取得座標(毫米)
        /// </summary>
        /// <param name="degree">弧度</param>
        /// <param name="distance">距離</param>
        /// <returns>座標</returns>
        public static (double x, double y) GetPoint(double degree, double distance) {
            return (
                 Math.Cos(degree) * distance,
                 Math.Sin(degree) * distance
            );
        }

        /// <summary>
        /// 座標轉換
        /// </summary>
        /// <param name="point">原始座標</param>
        /// <returns>轉換座標</returns>
        public (int x, int y) ConvertPosition((double x, double y) point) {
            var dX = (screenWidth / decimal.ToDouble(MaxX.Value - MinX.Value));
            var dY = (screenHeight / decimal.ToDouble(MaxY.Value - MinY.Value));

            int offsetX = 0, offsetY = 0;

            int offsetX2 = 0, offsetY2 = 0;

            int offsetX3 = 0, offsetY3 = 0;
            this.Invoke((MethodInvoker)delegate () {
                offsetX = offsetX_Control.Value;
                offsetY = offsetY_Control.Value;

                offsetX2 = offsetX2_Control.Value;
                offsetY2 = offsetY2_Control.Value;

                offsetX3 = offsetX3_Control.Value;
                offsetY3 = offsetY3_Control.Value;
            });

            var length = Math.Sqrt(Math.Pow(point.x, 2) + Math.Pow(point.y, 2));
            var maxLength = Math.Sqrt(Math.Pow((int)MaxX.Value - (int)MinX.Value, 2) + Math.Pow((int)MaxY.Value - (int)MinY.Value, 2));

            WriteLog($"I,距離:{length}/{maxLength}");

            double off_X = 0, off_Y = 0;

            if (length < maxLength / 2) { //近~中
                WriteLog($"I,距離:近");


                var dOffsetX = (offsetX2 - offsetX) / (maxLength / 2.0);
                var dOffsetY = (offsetY2 - offsetY) / (maxLength / 2.0);
                off_X = length * dOffsetX + offsetX;
                off_Y = length * dOffsetY + offsetY;
            } else { // 中~遠
                WriteLog($"I,距離:遠");

                var dOffsetX = (offsetX3 - offsetX2) / (maxLength / 2.0);
                var dOffsetY = (offsetY3 - offsetY2) / (maxLength / 2.0);
                off_X = length * dOffsetX + offsetX2;
                off_Y = length * dOffsetY + offsetY2;
            }

            var m = length / maxLength;



            return (x: (int)(Math.Abs((point.x - decimal.ToDouble(MinX.Value)) * dX + off_X)),
                y: screenHeight - (int)(Math.Abs((point.y - decimal.ToDouble(MinY.Value)) * dY - off_Y)));
        }

    }
}
