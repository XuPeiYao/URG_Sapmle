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

            while (true) {
                if (runner == null) break;
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
                if (ManObj["PNPDeviceID"].ToString() == @"USB\VID_15D1&PID_0000\6&381056B7&0&8") {
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

            this.Invoke((MethodInvoker)delegate () {
                offsetX = offsetX_Control.Value;
                offsetY = offsetY_Control.Value;
            });

            return (x: (int)(Math.Abs((point.x - decimal.ToDouble(MinX.Value)) * dX + offsetX)),
                y: screenHeight - (int)(Math.Abs((point.y - decimal.ToDouble(MinY.Value)) * dY - offsetY)));
        }

    }
}
