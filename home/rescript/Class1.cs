using System;
using System.Collections.Generic;
using System.Text;

namespace rescript
{
    // 先定义一个重新的类
    public class PdaItem
    {
        // 我们在下边定义一个可以去修改的类。
        /**
            1. 在这里我们重点注意,c#下边需要重写的实例方法和属性需要加入virual这个标识符，如果去掉会报错
            2. c#下切记字段和任何静态成员的重写都是不支持的。
         **/
        public virtual string Name { get; set; }
    }
   
}

