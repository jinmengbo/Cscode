using System;
using System.Threading;

namespace ThreadOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            t.Start();
            t.Join();
            for (int i = 0; i < 1000; i++) Console.Write("x");
            // Thread.Sleep方法将当前线程的执行暂停指定的时间：
            Thread.Sleep(TimeSpan.FromHours(1)); // 休息一小时
            Thread.Sleep(500);   // 休息500毫秒
        }
        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}
