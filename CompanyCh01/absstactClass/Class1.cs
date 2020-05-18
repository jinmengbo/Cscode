using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml;

namespace absstactClass
{
    // 定义一个抽象的类
   public abstract class PdaItem
    {
        // 定义一个字段(成员)。
        public PdaItem(string name)
        {
            Name = name;
        }

        public virtual string Name { get; set; }
        //定义抽象的字段(成员)
        public abstract string GetSummary();
    }
    // 派生的类
    public class Contact : PdaItem
    {
        public Contact(string name)
            // 这个Base的意义就是调用了PdaItem自身。 
            : base(name)
        {

        }
        public override string Name { 
            get => $"{FileName}{LastName}";
            set
            {
                string[] names = value.Split(" ");
                FileName = names[0];
                LastName = names[1];
            }
                
                }
        public string FileName { get; set; }
        public string LastName { get; set; }
        public string addres { get; set; }

        public override string GetSummary()
        {
            return $"FirstName:{ FileName}"
                + $"LastName{LastName}"
                + $"addres{addres}";
        }
    }
    public class Appointment : PdaItem
    {
        public Appointment(string name):
            base(name)
        {
            Name = name;
        }
            
        public override string GetSummary()
        {
            return $"Subject: { Name }"
                + $"Start: { StartDateTime  }"
                + $"End: { EndDateTime  }"
                + $"Location: { Location }";
        }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }

    }

}
