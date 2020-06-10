using System;
using System.Runtime.CompilerServices;

namespace tfcharacter
{
    class Program
    {
        static void Main() => Foo();
        static void Foo([CallerMemberName] string MemberName=null,[CallerFilePath] string filePahth=null,
            [CallerLineNumber] int lineNumber=0)
        {
            Console.WriteLine(MemberName) ;
            Console.WriteLine(filePahth);
            Console.WriteLine(lineNumber);

        }
    }
}
