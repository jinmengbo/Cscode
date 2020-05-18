using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("执行我们这个画矩形的代码");
            base.Draw();
        }
    }
}
