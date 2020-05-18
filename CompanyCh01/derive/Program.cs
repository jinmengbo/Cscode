using System;

namespace derive
{
    class Program
    {
        static void Main(string[] args)
        {
            //写方法继承我们写的Contact类。
            Contact contact = new Contact();
            // 调用我们继承的类中的方法,我们进行修改我们继承类中的方法,内容.
            contact.Name = "jinmengbo";
            // 然后我们看一下我们输出是否成功.
            Console.WriteLine(contact.Name);
            /**
              1. 结果就是我们调用的继承的父类的类，成功被我们这边继承的方法修改成功初始化的值了,得出结论实例化的方法值大于初始化的值。
              2. 我们可以看出来,c#他的派生的类，我们用方法在进行实例化后，继承是可以修改的。 
              3. c# 继承类的方法就是 : 这个冒号。
                 举个例子我们看一下继承的关系：
                    1).我们定义的最开始的类是,public class PadItem : object 他其实就是继承的Ojbect，在这里重点注意，除非我们明确指定了基类，否者所有类都是从object中继承的。
                    2). public class Appointment : pdaIem
                    3). public class Contact :PdaIem
                    4). public class Cutomer : Contact
              4. 在这里重点说一下c#,声明类的时候如果没有Public 声明是公共的，那他就是私有的,如果这时候去继承会提示权限问题。
             **/
            // 分割线---------分割线------------分割线
            /**
              下边例子是隐式基类转换。
              派生类Contact属于PdaItem这个类型，所以我们可以直接赋给PadItem类型的变量，这属于隐式转换，不需要其他操作。
             **/
            // 我们还是用上一个我们写的 Contact这个继承类做实验,首先我们还是写方法创建实例。
            Contact contact1 = new Contact();
            // 然后我们把这个继承的实例赋值给，item这个对象, item他的类型是我们上一个定义的PadItem这个。
            PadItem item = contact;
            // 下边就属于显示转换。
            contact = (Contact)item;

        }
    }
}
