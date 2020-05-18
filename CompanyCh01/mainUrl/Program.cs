using System;
namespace mainUrl
{
    class Program
    {
        static void Main(string[] args)
        {
            // 我们在这里声明类的变量，找了两个参数去继承它的类方法。
            //Employee employee1, employee2;
            // 我们在这里演示了一下，实例化类。声明和赋值既能在同一行上完成，也能分行完成。
            Employee employee1 = new Employee();
            Employee employee2;
            employee2 = new Employee();
            // 调用IncreseSalaary
            IncreseSalary(employee1);
            // 我们在下边访问我们的类下边的字段。
            employee1.FirstName = "金金";
            employee1.LastName = "胖胖";
            employee1.Salary = "修改后的Salary";
            //IncreseSalary(employee1);
            // 通过上边的例子我们可以看出来，我们上边的employee1修改过Salay，然后最终结果输出确是，IncreseSalay下边的。会发现方法重构后，在输出是方法重构后的结果。
            //Console.WriteLine($"输出 {employee1.FirstName} {employee1.LastName} {employee1.Salary}");
            // 我们在这里在进行修改一下实例化输出
            Console.WriteLine($"{ employee1.GetName()} { employee1.Salary}" );
            Console.WriteLine();
            //我们在这里重新输出一下
            Employee emp = new Employee();
            emp.SetName("金金", "胖胖");
            // 开始重构对应DataStorage下的实例
            Employee employee3;
            Employee employee4 = new Employee();
            employee4.SetName("Inigo","Montoya");
            employee4.Save();
            IncreseSalary(employee4);
            employee3 = DataStorage.load("Inggo", "Montoya");
            Console.WriteLine(
                $"{employee3.GetName()}{employee3.Salary}"
                );
        }
        static void IncreseSalary(Employee employee)
        {
            employee.Salary = "这是下边定义的一个方法更改的";
        }
    }
}
