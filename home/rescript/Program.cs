using System;

namespace rescript
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化一下我们的方法
            Contact contact = new Contact();
            // 我们在这里把contact这个实例化的方法赋值给PdaItem下的item这个变量,因为contact继承的是PdaItem所以他直接赋值是可以行的通。
            PdaItem item=contact;
            item.Name = "jin jin";
            Console.WriteLine(
                $"{contact.FistName}{contact.LasrtName}"
                );
            

        }
    }
}
