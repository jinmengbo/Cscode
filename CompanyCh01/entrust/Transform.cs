using System;
using System.Collections.Generic;
using System.Text;

namespace entrust
{
    public delegate int Transformer(int x);
    class Transforme
    {
        public static void Transform(int[] values,Transformer t)
        {
            for (int c = 0; c < values.Length; c++)
                values[c] = t(values[c]);
            {

            }
        }
    }
}
