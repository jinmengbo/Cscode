using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Triangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("执行我们这个画三角形的代码");
            base.Draw();
        }
    }
}
