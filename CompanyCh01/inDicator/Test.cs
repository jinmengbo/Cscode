using System;
using System.Collections.Generic;
using System.Text;

namespace inDicator
{
    class Test
    {
        int x;
        static void Main()
        {
            Test test = new Test();
            unsafe
            {
                {
                    fixed (int* p = &test.x)

                    {
                        *p = 9;


                    }
                    Console.WriteLine(test.x);
                }

            }

        }
    }
}
