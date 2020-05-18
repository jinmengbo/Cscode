using System;
using System.Collections.Generic;
using System.Text;

namespace Apifour
{
    interface IUndoable { void Undo(); }
    public class TextBox : IUndoable
    {
        void IUndoable.Undo() => Undo();
        //void IUndoable.Undo() => Console.WriteLine("显示实现方法Undo");
        //public void Undo() => Console.WriteLine("实现了TextBox");
        protected virtual void Undo() => Console.WriteLine("实现了TextBox");
    }
    public class ReadTextBox : TextBox, IUndoable
    {
        //public new void Undo() => Console.WriteLine("实现了ReadTextBox");
        protected override void Undo() => Console.WriteLine("实现了ReadTextBox");
    }
}
