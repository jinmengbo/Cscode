using System;

namespace rewrite
{
    class Program
    {
        static void Main(string[] args)
        {
            SubDervedClass subDervedClass = new SubDervedClass();
            DervedClass dervedClass = subDervedClass;
            Person.Baseclass baseclass = subDervedClass;
            subDervedClass.DisplayName();
            dervedClass.DisplayName();
            baseclass.DisplayName();



        }
    }
}
