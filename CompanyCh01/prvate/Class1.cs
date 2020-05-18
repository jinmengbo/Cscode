using System;
using System.Collections.Generic;
using System.Text;

namespace prvate
{
    class Employee
    {
        public string FistName
        {
            // get这个方法其实就是对应的是取值,类似于employee.FistName
            get
            {
                return _FistName;
            }
            // set这个方法就是赋值，我们更推荐这种写法，比上一个写法更加的方便一些，。
            set
            {
                _FistName = value;
            }
        }
        private string _FistName;
        // 用表达式去实现，这是7.0开始推荐的表达式，取值，赋值方法。
        public string LastName
        {
            get => _LastName;
            set =>_LastName= value;
        }
        // 先定义我们的私有字段。
        private string _LastName;
        // 最推荐的写法是下边这个,去自动实现。
        public string Title { get; set; } = "jinjin";
        public Employee Manager { get; set; }
        public string Salary { get; set; } = "Not Enogh";
        // 属性的验证写法
        public void Initialize(string NewFistName,string NewLastName)
        {
            FistName = NewFistName;
            LasrName1 = NewLastName;
        }
       public string LasrName1 
        {
            get => _LastName;
            set
            {
                if (value==null)
                {
                    // 这句话就是如果我们这个方法提供的参数其中有无效的时候就会引发异常。
                    throw new ArgumentOutOfRangeException("value");
                }
                else
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentOutOfRangeException(
                           "lastName Vlue");
                    }
                    else _LastName = value;
                }
            }
        }
    }
}
