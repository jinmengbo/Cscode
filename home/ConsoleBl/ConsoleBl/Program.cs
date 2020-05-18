using System;

namespace ConsoleBl
{
    class Program
    {
        static void Split(string name, out string firstNames, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }
        static void Main(string[] args)
        {
            // Out丢弃变量,在c#7中可以允许调用Out方法时直接声明这个变量
            Split("Jin meng bo", out string a, out string b);
            // 我们可以打印一下这个结果是什么。
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
