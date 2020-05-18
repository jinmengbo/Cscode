using System;
using System.Text;
namespace parameter
{
    class Program
    {
        // 4. 加上ree修饰符。
        static void Foo(ref int x)
        {
            x=x+1;
            System.Console.WriteLine(x);
        }
        //---------------------//
        // static void Foo(StringBuilder  fooSB)
        // {
        //     fooSB.Append("jinjin");
        //     fooSB=null;
        // }
        // 5. 对应下边标号为5的例子
        static void Swap(ref string a,ref string b)
        {
            string temp=a;
            a=b;
            b=temp;
        }
        // 6. 对应下标号为6的例子。
        static void Split(string name ,out string firstNames,out string lastname)
        {
            int i =name.LastIndexOf(' ');
            firstNames =name.Substring(0,i);
            lastname = name.Substring(i+1);
            System.Console.WriteLine(firstNames);
            System.Console.WriteLine(lastname);
        }
        static void Main(string[] args)
        {
            // 2. 我这里创建一个变量进行赋值。
            // int x=8;
            // Foo(x);
            // 我们可以看一下这个结果是什么
                // 1.) 9 8，显然易见，我们在这里调用的x是我们这个变量，而不是在Foo下的x变量。
            // System.Console.WriteLine(x);
            // 3. 输出fooSB
            // StringBuilder sb=new StringBuilder();
            // Foo(sb);
            // System.Console.WriteLine(sb);
            // 4. 加上ref修饰符，会发现,我们加上ree修饰符然后,给Foo下的x值，也会把现在定义的x值改变。
                // 重点是，ref这个修饰符呢，在声明和调用的时候，都是需要采用的。
            // int x=5;
            // Foo(ref x);
            // System.Console.WriteLine(x);
            // // 5. 调用
            // string a ="Penn";
            // string b="Teller";
            // Swap(ref a ,ref b);
            // System.Console.WriteLine(a);
            // System.Console.WriteLine(b);
            string a,b;
            Split("jinbo jin",out a,out b);
        }
    }
}
