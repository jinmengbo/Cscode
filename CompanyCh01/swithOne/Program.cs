using System;
using System.Threading;

namespace swithOne
{
    class Program
    {
        // object类型允许其变量为任何类型
         /** static void TellMap(object x)
           {
            switch (x)
	{
                    case int i:
                        Console.WriteLine($"输出结果{i}is{i*i}");
                        break;
                    case string s:
                        Console.WriteLine($"输出字符串的结果{s}");
                        break;
		            default:
                        Console.WriteLine("这就是其他类型的");
                        break;
	}
        } **/
            


        static void Main(string[] args)
        {
         /**   TellMap(12);
            TellMap("hello");
            TellMap(true);
            **/
            // 打印前10个斐波那契数
           /** for (int i = 0 ,c=1, b=1;  i < 10; i++)
			{
                Console.WriteLine(c);
                int newFib=c+b;
                c=b;b=newFib;
			} **/
           // continue语句
          /* for (int i = 0; i < 10; i++)
			{
                if((i%2)==0)
                    continue;
			}
           Console.WriteLine(i+" ");
           */
           /* goto语句将执行点转移到语句块中的指定标签处。格式如下：
              goto statemt-label
            */
            int i=1;
            // 这个只是一个占位符，我们在下边goto 去调用它他在执行这个标签语句下边的方法，直到这个语句不成立。
            startLoop:
            if (i<=5)
                {
                Console.WriteLine(i+" ");
                i++;
                goto startLoop;
            }
        }
    }
}