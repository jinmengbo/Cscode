using System;
using System.Collections.Generic;
using System.Text;

namespace GenEric
{
    class Stack
    {
        //int position;
        //T[] data = new T[100];
        //public void Push(T obj) => data[position++] = obj;
        //public T Pop() => data[--position];
        public virtual object Pop() { }
        public virtual void Push(object obj) { }
    }
}
