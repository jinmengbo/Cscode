using System;

namespace Jtuple
{
    class Program
    {
        static (string, int, string) GoPle => ("jintian", 23, "男");
        static void Main(string[] args)
        {
            var jin = ("jin", "23","chines");
            Console.WriteLine(jin.Item1);
            Console.WriteLine(jin.Item2);
            Console.WriteLine(jin.Item3);
            var jinmengbo = jin;
            jinmengbo.Item3 = "jinbobo";
            Console.WriteLine(jin);
            Console.WriteLine(jinmengbo);
            var Person = GoPle;
            Console.WriteLine($"{Person.Item1}");
            Console.WriteLine($"{Person.Item2}");
            Console.WriteLine($"{Person.Item3}");
            ValueTuple<string, int> boo1 = ValueTuple.Create("jin", 25);
            // 下边写法效果和上方一致。
            var (name, age, sex) = GoPle;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(sex);

        }
    }
}
