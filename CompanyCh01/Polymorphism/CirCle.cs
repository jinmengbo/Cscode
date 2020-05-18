using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // 继承我们上边的矩形形状 
    class CirCle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("我们执行这个画圆代码 ");
            // 然后我们在这里也调用了一下我们派生的类的方法。
            base.Draw();
        }

    }
}
