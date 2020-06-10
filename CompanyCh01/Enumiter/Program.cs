using System;
using System.Collections.Generic;

namespace Enumiter
{
    class Program
    {


        static void Main(string[] args)
        {
            foreach (var item in "collection")
            {
                Console.WriteLine(item);

            }
            List<int> ite=new List<int> {1,2,3 };
            Console.WriteLine(ite);
            var dict = new Dictionary<int, string>
            {
                // 两种写法都是定义字典的,后者更简洁,不仅适用于字典,而且适用于任何具有索引器的类型。
                //{5,"jinjin" },
                //{6,"bobo" }
                [4] = "jinmengbo"

            };
            var i = dict[4];
            Console.WriteLine(i);
            foreach (var item in Fibs(6))
            {
                Console.WriteLine(item+" ");

            }
            foreach (var item in GetVs())
            {
                Console.WriteLine(item);
            }
            foreach (var item in Foo())
            {
                Console.WriteLine(item);

            }
            int? f= null;
            Console.WriteLine(f==null);
        }
        // 1. yield return语句则表示“这是当前枚举器产生的下一个元素”。在每条yield语句中，控制都返回给调用者，
        // 2. 但是必须同时维护调用者的状态，以便调用者枚举下一个元素的时候，方法能够继续执行
        static IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib=1,curFib=1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;

            }
        }
        static IEnumerable<int> GetVs()
        {
            int index = 0;
            while (index < 10)
                yield return index++;
        }
        static IEnumerable<string> Foo()
        {
            yield return "One";
            yield return "Two";
            yield return "Three";
        }
    }
}
