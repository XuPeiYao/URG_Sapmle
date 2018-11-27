using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Timer = System.Timers.Timer;
using System.Linq;
using URG.Library;
using System.IO.Ports;
using System.Management;
using System.Timers;
using System.Windows.Forms;

namespace URG_Sample {
    class Program {
        /// <summary>
        /// 鼠标控制参数
        /// </summary>
        const int MOUSEEVENTF_LEFTDOWN = 0x2;
        const int MOUSEEVENTF_LEFTUP = 0x4;
        const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        const int MOUSEEVENTF_MIDDLEUP = 0x40;
        const int MOUSEEVENTF_MOVE = 0x1;
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        const int MOUSEEVENTF_RIGHTUP = 0x10;

        /// <summary>
        /// 鼠标的位置
        /// </summary>
        public struct Point {
            public int x, y;
        }

        [DllImport("user32.dll")]
        public static extern int GetCursorPos(ref Point p);

        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        static readonly int offsetX = 0;
        static readonly int offsetY = 1180;

        static readonly int width = 1535 + offsetX;
        static readonly int height = 760 + offsetY;


        private static Hokuyo hokuyo;

        private static Point currentPoint;

        public static int minY = 120;
        public static int maxY = 440;
        public static int minX = 0;
        public static int maxX = 410;

        public static int ScreenWidth = 1024;
        public static int ScreenHeight = 768;

        public static int OffsetScreenY = -200;
        public static int OffsetScreenX = 100;

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
                        int.Parse(ManObj["MaxBaudRate"].ToString()));
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
        public static (int x, int y) ConvertPosition((double x, double y) point) {
            var dX = (ScreenWidth / (maxX - minX));
            var dY = (ScreenHeight / (maxY - minY));

            return (x: (int)(Math.Abs((point.x - minX) * dX - OffsetScreenX)), y: ScreenHeight - (int)(Math.Abs((point.y - minY) * dY - OffsetScreenY)));
        }

        [STAThread]
        static void Main() {
            ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            var findConnectionInfo = GetDeviceConnectionInfo();
            if (findConnectionInfo.comPort == 0) {
                Console.WriteLine("找不到裝置，請確認裝置已經插入USB插槽");
                Console.ReadKey();
                return;
            }

            using (hokuyo = new Hokuyo(findConnectionInfo.comPort, findConnectionInfo.baudRate))
            using (Timer tmr = new Timer { Interval = 120 }) {
                tmr.Elapsed += delegate (object sender, ElapsedEventArgs e) {
                    try {
                        Tmr_Elapsed(sender, e);
                    } catch {
                    }
                };  // 使用事件代替委託
                tmr.Start();          // 開啟定時器
                Console.ReadLine();
                tmr.Stop();          // 停止定時器
                Console.ReadLine();
                tmr.Start();          // 重啟定時器
                Console.ReadLine();
            }

            Point p = new Point();
            GetCursorPos(ref p);

            var key = Console.ReadKey();
            //if (key.Equals(ConsoleKey.Escape)) {
            hokuyo.Disconnect();
            //}
        }

        [STAThread]
        static void Tmr_Elapsed(object sender, EventArgs e) {
            var rawDistanceValues = hokuyo.GetData();
            var rawPoints = rawDistanceValues
                    .Skip(128 - 44).Take(384 - 128)
                    .Select((x, i) => new {
                        degree = i * ((Math.PI / 2) / (384 - 128)),
                        distance = x
                    })
                    .Select(x => GetPoint(x.degree, x.distance))
                    .Where(x => x.x >= minX && x.x <= maxX && x.y >= minY && x.y <= maxY);

            var currentPoint = (
                x: rawPoints.Sum(x => x.x) / rawPoints.Count(),
                y: rawPoints.Sum(x => x.y) / rawPoints.Count()
            );

            if (double.IsNaN(currentPoint.x) ||
               double.IsNaN(currentPoint.y)) {
                return;
            }

            currentPoint = ConvertPosition(currentPoint);

            SetCursorPos((int)currentPoint.x, (int)currentPoint.y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, (int)currentPoint.x, (int)currentPoint.y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, (int)currentPoint.x, (int)currentPoint.y, 0, 0);

            Console.WriteLine($"x: {currentPoint.x}, y: {currentPoint.y}");
        }
    }
}
