using System;

namespace prvate
{
    class Program
    {
        //声明一个私有字段
        private string FistName;
        // 声明一个方法，谁调用我，就把上边私有的字段返回过去
        public string GetFistName()
        {
            return FistName;
        }
        // 声明一个方法，来时做判断，调用私有字段。 
        public void SerFistNaem(string newFistName)
        {
            // 判断如果他不是Null,和不是空的情况下，我们这个方法传的字段等于私有字段。
            if (newFistName !=null && newFistName!="")
            {
                FistName = newFistName;
            }
        
        }
        // 在去定义一个私有字段。
        private string LastName;
        // 写法和上边一样，用法一致。
        public void GetLastName(string newLastName)
        {
            if (newLastName!=LastName && newLastName!="")
            {
                LastName = newLastName;
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            //employee.FistName = "jinjin";
            // 输出结果就是，jinjin
            //Console.WriteLine(employee.FistName);
            // 我们使用表达式写的进行调用
            //employee.LastName = "jinmengbo";
            //Console.WriteLine(employee.LastName);
            // 简单的说一下逻辑吧，这是一个赋值,但是我们在c#6以后就可以直接把这个值初始化了，而不用这样麻烦。
            //employee1.Title = "Computer Merd";
            // 这句话的意思是,因为我Manager他是继承的Employee这个类，他要传入Employee的方法,所以我把employee1传给了employee了。
            //employee.Manager = employee1;
            Console.WriteLine(employee.Title);
            Console.WriteLine(employee.Salary);
            
           
        }
    }
}
