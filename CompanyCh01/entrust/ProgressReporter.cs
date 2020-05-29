using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace entrust
{
    public delegate void ProgressReporter(int percentComplete);
    class ProgressRepor
    {
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);

            }
            Thread.Sleep(100);
        }
    }
}
