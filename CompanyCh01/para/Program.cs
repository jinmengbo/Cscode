using System;

namespace para
{
    class Program
    {
        //static int Sum(params int[] ints)

        //{
        //        int sum = 0;
        //    for (int i=0;i<ints.Length;i++)
        //    {
        //        sum+=ints[i];
        //    }
        //        return sum;
        //    }
        // 可选参数的写法
        //static void Foo(int x=23,int y=30) { Console.WriteLine(x+", "+y); }
        // 引用返回值
        static string x = "value";
        static ref string Getef => ref x;
        
        static void Main(string[] args)
        {
            //int total =Sum(1,2,3,4);
            //System.Console.WriteLine(total);
            //Foo(1);
            // 引用局部变量
            //int[] numbers = { 0, 1, 2, 3, 4 };
            //ref int numRef = ref numbers[2];
            //numRef *= 10;
            //Console.WriteLine(numRef);
            //Console.WriteLine(numbers[2]);
            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            // 引用返回值
            ref string Xref = ref Getef;
            Xref = "New Value";
            Console.WriteLine(Xref);
        }
    }
}
