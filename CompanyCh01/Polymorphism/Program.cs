using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new CirCle(),
                new Rectangle(),
                new Triangle()
            };
            foreach (var item in shapes)
            {
                item.Draw();
            }
     
        }
    }
}
