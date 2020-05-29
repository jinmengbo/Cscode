using System;
using System.Collections.Generic;
using System.Text;

namespace entrust
{
    // 变成委泛型
    public delegate T Transformer<T>(T arg);
    //public delegate int Transformer(int x);
    class Transforme
    {
        public static void Transform<T>(T[] values, Transformer<T> t)
        //public static void Transform(int[] values,Transformer t)
        {
            for (int c = 0; c < values.Length; c++)
                values[c] = t(values[c]);
            {

            }
        }
    }
}
