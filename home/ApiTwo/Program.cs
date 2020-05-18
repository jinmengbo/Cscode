using System;

namespace ApiTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 我们可以把对象隐式转换为它实现的任意一个接口。
            IEnumerator e=new Countdown();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
        }
    }
}
