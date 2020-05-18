using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTwo
{
    /*
     * 1. 我们能定义了一个简单接口来做演示,扩展接口
     * 2. 在中定义了一个没有返回值的类。
     * 3. 谁继承我,谁也就要按照我这个契约去实现我下边的方法。
     */
    interface IUndoable
    {
        void Undo();
    }
}
