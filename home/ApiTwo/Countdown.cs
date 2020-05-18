using System;

namespace ApiTwo
{
    // 我们定义一个类,然后继承了我们定义的接口。
    class Countdown : IEnumerator
    {
        private int count = 11;
        public bool MoveNext() => count -- > 0;
        public object Current => count;
        public void Rest()
        {
            throw new NotSupportedException();;
        }
    }
}