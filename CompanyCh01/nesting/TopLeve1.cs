using System;
using System.Collections.Generic;
using System.Text;

namespace nesting
/*嵌套类型有如下的特征：
 * · 可以访问包含它的外层类型中的私有成员，以及外层类所能够访问的所有内容。
 * · 可以在声明上使用所有的访问权限修饰符，而不限于public和internal。
 * · 嵌套类型的默认可访问性是private而不是internal。
 * · 从外层类以外访问嵌套类型，需要使用外层类名称进行限定（就像访问静态成员一样）。
 */
{
    public class TopLeve1
    {
        // public class Nested { }
        //public enum Color
        //{
        //    Red,Blue,Tan

        //}
        // 以下示例在嵌套类型中访问外层私有成员：
        // static int x;
        //private class Nested
        // {
        //     static void Foo() { Console.WriteLine(x); }
        // }
       // 以下示例在嵌套类型上使用protected访问权限修饰符：
       protected class Nested
        {
        }
        public class SubTopLevo1 : TopLeve1
        {
            static void Foo() { new Nested(); }
        }
    }
    class Test
    {
        TopLeve1.SubTopLevo1 n;
    }
}
