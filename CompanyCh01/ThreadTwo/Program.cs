using System;
using System.Threading;

namespace ThreadTwo
{
    class Program
    {
        //如果不同的线程拥有同一个对象的引用，则这些线程之间就共享了数据
        //bool done;
        // 演示加锁
        static bool done;
        static readonly object _locket = new object();
        static void Main(string[] args)
        {
            //new Thread(Go).Start();
            //Go();
            //Program tt = new Program();
            //new Thread(tt.Go).Start();
            //tt.Go();
            //bool done = false;
            //ThreadStart action = () =>
            //{
            //    if (!done) {  Console.WriteLine("Done"); done = true; }
            //};
            //new Thread(action).Start();
            //action();
            // ----加锁
            new Thread (GO).Start();
            GO();
        }
        //static void Go(){   //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("?"); ;
        //}}
        // void Go()
        //{

        //    if (! done) { done = true; Console.WriteLine("Done"); }

        //}
        // ----加锁
        static void GO()
        {
            lock (_locket)
            {
                if (!done) { Console.WriteLine("Done");done = true; }
            }
        }
    }
}
