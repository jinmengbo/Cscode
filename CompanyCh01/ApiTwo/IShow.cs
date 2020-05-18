using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTwo
{
    /*
     * 1. 下边例子演示，显示接口实现。
     * 2. 因为接口不能实例化的,所以我们只能让Widget类去继承。
     * 3. 我们在两个接口中,定义了两个名称一样的方法。
     * 4. 我们写了一个类,继承了我们这两个接口,在以前的记录有说明,继承了接口,我们就要按照契约协议走,所以我们就要实现这两个方法,但是呢,他们呢都是同样的方法名,通过隐式我们去实现两个方法,肯定比较难办。
     * 5. 所以我们就用了显示,直接说明是哪个接口下的方法,实现什么。
     */
    interface IShow { void Foo(); }
    interface IShow2 { int Foo(); }
    public class Widget : IShow,IShow2
    {
        public void Foo()
        {
            Console.WriteLine("返回IShow下边的FOO");
        }
        int IShow2.Foo()
        {
            Console.WriteLine("返回IShow2下边的FOO");
            return 42;
        }
       
    
    }
}
