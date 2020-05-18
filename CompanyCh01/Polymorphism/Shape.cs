using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Shape
    {
        // 定义字段 
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get;  set; }
        public int Width { get; set; }
        // 定义一个虚拟的方法
        public virtual void Draw()
        {
            Console.WriteLine("执行我们这个画图的操作");
        }
    }
}
