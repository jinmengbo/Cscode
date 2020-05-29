using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace incident
{
    class Program
    {
        public delegate bool CallBack(int hwnd, int lParam);

        public class EnumReportApp
        {
            [DllImport("user32")]
            public static extern int EnumWindows(CallBack x, int y);

            public static void Main()
            {
                CallBack myCallBack = new CallBack(EnumReportApp.Report);
                EnumWindows(myCallBack, 0);
            }

            public static bool Report(int hwnd, int lParam)
            {
                Console.Write("Window handle is ");
                Console.WriteLine(hwnd);
                return true;
            }
        }
    }
}
