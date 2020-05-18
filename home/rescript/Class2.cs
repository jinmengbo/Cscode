using System;
using System.Collections.Generic;
using System.Text;

namespace rescript
{
    // 我们在这里新建一个继承的类，为了写在一块觉得难以读懂，所以我们在这里写一个继承的类。
    public class Contact : PdaItem
    {
        // 我们开始重写我们继承的类下的方法,切记c#下要重写的加入override这个标识符。
        public override string Name 
        {
            get
            {
                return $"{FistName}{LasrtName}";
            }
            set
            {
                // 这个地方我们去除字空符串
                string[] names = value.Split(" ");
                FistName =names[0];
                LasrtName = names[1];
            }
                }
        public string FistName { get; set; }
        public string LasrtName { get; set; }
    }
    // 为了上边重新的类，进行调用，我在这下边又声明了俩个字段。
    


}
