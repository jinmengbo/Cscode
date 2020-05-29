using System;
using System.Collections.Generic;
using System.Text;

namespace entrust
{
    public delegate int NumberChanger(int x);
    class NumberChang
    {
        static int y = 10;
        public  int AddNum (int p)
        {
            y += p;
            return y;
        }
        public  int NulNum(int t)
        {
            y *= t;
            return y;
        }
        public  int GetNum()
        {
            return y;
        }
    }
}
