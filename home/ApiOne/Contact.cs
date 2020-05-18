using System;

namespace ApiOne
/*
 * 在这里说一下接口吧，接口的重点在于永远不能实例化，不能用new创建接口，所以我们可以推论出,接口没有构造函数或者终结器。
 * 只有实例化实现了接口的类型才能使用接口实例。所以，接口不能包含静态的成员，接口为多态性，而生。
 * 加入没有实现接口的那个类型的实例，多态性其实也没有什么意义存在。
 * 每个接口成员行为和抽象方法挺相似的，都是强迫派生类(继承类)实现成员,但是不能为接口成员显示添加上abstract修饰符。
 * 类型中实现接口成员有两种的方式，显示和隐式。 我下班写的都是隐式实现，
 */
{
    // 我们定义一个类，然后继承，我们IListable下边的接口，和方法。
     public class Contact: PdaItem,IListable
    {
        // 我们在这里定义一个预处理的指令，但是他不会执行。
        #region  IComparable Members
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// Less than zero:      This instance is less than obj
        /// Zero                 This instance is equal to obj 
        /// Greater than zero    This instance is greater than obj 
        /// </returns>
        #endregion

        // 开始定义一个新的方法
        public int CompareTo(object obj)
        {
            int result;
            Contact contact = obj as Contact;
            if (obj == null)
            {
                result = 1;
            }
            else if (obj.GetType()!=typeof(Contact))
            {
                throw new ArgumentException(
                    $"The parameter is not a value of type {nameof(Contact)}",
                    nameof(obj));
            }
            else if(Contact.ReferenceEquals(this,obj))
            {
                result = 0;
            }
            else
            {
                result = LastName.CompareTo(contact.LastName);
                if (result == 0)
                {
                    result = FirstName.CompareTo(contact.FirstName);
                }
                {
                    
                }
            }

            return result;
        }

        #region IListable Members

        string[] IListable.ColumnValues
        {
            get
            {
                return new string[]
                {
                    FirstName,
                    LastName,
                    Phone,
                    Address

                };
            }
        }
        
        #endregion

        public override string Name { get
            {
                return FirstName + " " + LastName;
            }
            set
            {
                // Split the assigned value into 
                // first and last names
                string[] names;
                names = value.Split(new char[] { ' ' });
                if(names.Length == 2)
                {
                    FirstName = names[0];
                    LastName = names[1];
                }
                else
                {
                    // Throw an exception if the full 
                    // name was not assigned
                    throw new System.ArgumentException(
                        $"Assigned value '{value}' is invalid");
                }
            } }

        // 然后我们定义四个方法，因为我们接口定义的时候,是一个字符列表。然后我们下边调用接口的方法,返回过去。
        public Contact(string firstName, string lastName, string address, string phone) : base(null)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        // 去定义接口的方法，把我们上边定义的方法,返回过去。
        public string[] ColumnValues
        {
            get
            {
                return  new string[]
                {
                    FirstName,
                    LastName,
                    Phone,
                    Address
                };
            }
        }
        // 定义静态方法
        public static string[] Headers
        {
            get
            {
                return new String[]
                {
                    "First Name","Last Name",
                    "Phone    ",
                    "Address    "
                };
            }
        } 
    }
     
}