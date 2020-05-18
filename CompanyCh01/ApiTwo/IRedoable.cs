using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTwo
{
    /* 
     * 1. 因为我们定义的IRedoable这个接口,继承了IUndoable，按照契约我们要去实现他下边的方法,所以我们定义了一个没有返回字段Redo
     * 2. 所以我们得出结论，谁要实现IRedoable的这个类型他也必须要实现IUndoable的成员。
     */
    interface IRedoable :IUndoable
    {
        void Redo();
    }
}
