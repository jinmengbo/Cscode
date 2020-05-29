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
            NumberChang numberChang = new NumberChang();
            var num1 = new NumberChanger(numberChang.AddNum);
            var num2 = new NumberChanger(numberChang.NulNum);
            Console.WriteLine($"{num1(10)},{numberChang.GetNum()}");
            Console.WriteLine($"{num2(5)},{numberChang.GetNum()}");
            ProgressReporter p = Write;
            p += writeFile;
            p -= writeFile;
            ProgressRepor.HardWork(p);
            ProRepotrer pro = new ProRepotrer();
            ProRepo proRepo = pro.Instance;
            proRepo(99);
            Console.WriteLine(p.Target==pro);
            Console.WriteLine(p.Method);
        }
        static int Square(int x) => x * x;  
        static void Write(int percentComplete) => Console.WriteLine(percentComplete);
        static void writeFile(int percentComplete) => System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
    }

}
