using System;

namespace entrust
{
    //delegate int Transformer(int x);
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个Square的实例,这个语句其实就是下边这个
            //Transformer transformer = new Transformer (Square); 和下边语句同样效果
            //Transformer t = Square;
            //var result = t(3);
            //Console.WriteLine(result);
            int[] values = { 1, 2, 3 };
            Transforme.Transform (values, Square);
            foreach (var item in values)
            {
                Console.WriteLine(item+" ");
            }
        }
        static int Square(int x) => x * x;
    }

}
