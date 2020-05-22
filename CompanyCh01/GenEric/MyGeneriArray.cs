using System;
using System.Collections.Generic;
using System.Text;

namespace GenEric
{
    
    class MyGeneriArray <T>
    {
        private T[] array;
        public MyGeneriArray(int size)
        {
            array = new T[size + 1];
        }
    }
}
