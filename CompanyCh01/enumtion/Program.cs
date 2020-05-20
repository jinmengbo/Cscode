using System;

namespace enumtion
{
    class Program
    {
        /*
         *  1. c#的枚举类型默认是int类型的。
         *  2. 我们可以更改它的默认类型,只能更改整数类型。
         */ 
         // 默认的引用
        //public enum Un { Left,Right,Top,Bottom}
        // 更改的过的类型
        //public enum Unn :byte{
        //    Left,
        //    Right,
        //    TOp,
        //    Bottom
        //}
        // 还可以进行对枚举的成员进行赋值。
        public enum EnumTion
        {
            Left=2,
            Right=5,
            Top=15,
            Bottom=16
        }

        // 还可以对枚举成员部分进行赋值,最后没有赋值的枚举,自动对最后一个枚举的值+1。下边代码同上。
        public enum EnumError:byte
        {
            left=3,
            Rig=4,
            IO=5,
            Boo
        }

        static void Main(string[] args)
        {
            //var a = Un.l;
            //var d = (a == Un.l);
            //Console.WriteLine(d);
            //Console.WriteLine($"{EnumError.Boo}");
            //Season a = Season.Autumn;
            //Console.WriteLine($"{(int)a}");
            //var b = (Season)1;
            //Console.WriteLine(b);
            //var c = (Season)5;
            //Console.WriteLine($"{c}");
            int i = (int)EnumError.left;
            EnumError side = (EnumError)i;
            Console.WriteLine($"{(int)side}");
            var leftOrRight = (int)side >= 2;
            Console.WriteLine($"{leftOrRight}");
           
        }
    }
}
