using System;
using System.Collections.Generic;

namespace tectonic
{
    class Program
    {
        static void Main(string[] args)
        {
            Emloyee emloyee;
            emloyee = new Emloyee("jin","mengbo");
            emloyee.Salary = "is null";
            Console.WriteLine(
              $"{emloyee.FirstName },{emloyee.LastName},{emloyee.Salary}"
              );

            // 集合初始化器,简单说一下c#中的简单集合吧。
            List<Emloyee> emloyees = new List<Emloyee>()
            {
                new Emloyee("s","null"),
                new Emloyee("Not", "null")
            };

          
        }
    }
}
