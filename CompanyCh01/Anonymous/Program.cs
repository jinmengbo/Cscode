using System;
using System.Data.SqlTypes;

namespace Anonymous
{
    class Program
    {
        delegate int Transformer(int i);
        static void Main(string[] args)
        {
            Transformer sqr = x => x * x;
            Console.WriteLine(sqr(3));
            Func<string, string, int> to = (sq1, sq2) => sq1.Length + sq1.Length;
            var total = to("jinjin", "menfbo");
            Console.WriteLine(total);
            // 显示Lambada
            void Foo<T>(T x) { }
            void Bar<T>(Action<T> a) { }
            Bar<int>(x=>Foo(x));
            Bar<int>(Foo);
            // 捕获外部变量
            int fact = 2;
            Func<int, int> multiplier = n => n * fact;
            Console.WriteLine(multiplier(5));
            int factt = 3;
            Func<int, int> multi = n => n * factt;
            factt = 10;
            Console.WriteLine(multi(5));
            int sep = 0;
            Func<int> sepp = () => sep++;
            Console.WriteLine(sepp());
            Console.WriteLine(sepp());
            Console.WriteLine(sep);
            // 捕获迭代变量
            // 当捕获for循环的迭代变量时，C#会认为该变量是在循环体外定义的。而这意味着同一次变量在每一次迭代都被捕获了
            // 所以程序只会输出333而并并不是我们认为的012：
            // 我们如果想捕获成为,0,1,2,我们把将循环变量指定到循环内部的局部变量中就行了，例子中我加入了inden
            Action[] actions = new Action[3];
            for (int i = 0; i < 3; i++)
            {
                int inden = i;
                actions[i] = () => Console.WriteLine(inden);
            }
            foreach (Action item in actions) item();
            {

            }
        }
    }
}
