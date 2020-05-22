using System;
using System.Collections.Generic;
using System.Text;

namespace GenEric
{
    class Stack<T>
    {
       int position;
        T[] data = new T[100];
        public T Push(T obj) => data[++position]=obj;
        public T Pop() => data[--position];
    }
}
