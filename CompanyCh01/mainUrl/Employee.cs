using System;
using System.Collections.Generic;
using System.Text;

namespace mainUrl
{
    class Employee
    {
        // 我们对代码进行修改，添加一下三个公共字段。
        public string FirstName;
        public string LastName;
        public string Salary="我是没被修改之前的";
        // 方法声明没有用static来标记,因为静态方法不能直接访问类的实例字段。相反，必须先获得类的实例才能调用实例成员——无论该实例成员是方法还是字段。
        public string GetName() => $"{FirstName}{LastName}";
        // 在这里重新说一下，rhis关键字，
        public void SetName(string newFirstName,string newLastName)
        {
            // this我们可以看出来他就我们这个class Employee类。
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine($"Name changed to '{this.GetName()}'");
        }
        // 在这里写个新方法,调用的是我们的其他类。
        public void Save() => DataStorage.Store(this);
    }
}
