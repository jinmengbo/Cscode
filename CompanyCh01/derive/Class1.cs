using System;
using System.Collections.Generic;
using System.Text;

namespace derive
{
    // 定义PadItem类
    public class PadItem
    {
        // 定义字段
        public string Name { get; set; } = "金金";
        public DateTime LaseUpdatated { get; set; }
    }
    // 定义 Contact(联系人)继承PadItem这个类。注意，c#继承是:这个符号。
    public class Contact : PadItem
    {
        // 我在去编写两个字段。第一个Address是联系人.
        public string Address { get; set; }
        public string Phone { get; set; }


    }
}
