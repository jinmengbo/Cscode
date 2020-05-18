using System;

namespace ApiTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. 我们定义好了隐式接口，定义好了继承接口的类,也在类中实现了方法。
             * 2. 我们下边把对象隐式转换成为他实现的一个接口。
             * 3. 我们的Countdown这个类是internal权限,然后我们通过把CountDown实例转换为IEnumerator这个接口,然后我们其中内部实现的IEnumerator接口的成员,就可以当成公用成员访问了。
             * 4. 在这里解释一下internal这个权限,它的作用就是访问限于当前程序集,举个例子,我在A类定义了一个internal的类,那我们在类B中就无法实例,会报错,如果定义的是成员(方法),那我们就无法访问这个成员。
             * 5. 我又在最下边定义了一个其他的类,然后定了一个实例化的类,再通过调用者进行执行。两种方法去实现了。
             * 6. 如果我们定义的接口IEnumerato是internal，那我们写的方法就不能用了。
             */
            //Countdown e =new Countdown();
            //while (e.MoveNext())
            //{
            //    Console.WriteLine(e.Current);
            //}
            IEnumerator e = (IEnumerator)Util.GetCountDwon();
            while(e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
            /*
             * 下边列子是接口显示写法。
             * 1.实例化我们继承接口的类,因为接口不能实例化的,所以我们只能让类继承。
             * 2.我们如果通过实例化过后的变量，去调用实例化的类下边实现的方法，会发现,如果两个方法名称是一样的,我们隐式是无法调用到全部的。
             * 3.所以我们只能使用显示调用成员,方法就是将他们转换为对应的接口,比如((接口名)实例化的方法名).调用我们想要同名的方法名。
             */
            Widget widget = new Widget();
            widget.Foo();
            ((IShow2)widget).Foo();
            ((IShow)widget).Foo();
        }
        
    }
 
}
