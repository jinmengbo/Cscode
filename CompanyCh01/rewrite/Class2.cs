using System;
using System.Collections.Generic;
using System.Text;

namespace rewrite
{
    public class DervedClass :Person.Baseclass
    {
        public virtual void DisplayName()
        {
            Console.WriteLine("打印下我们的这个DervedClass类");
            
        }
    }
    public class SubDervedClass :DervedClass
    {
        public new void DisplayName()
        {
            Console.WriteLine("打印下我们的这个SubDervedClass类");
        }
    }
}
