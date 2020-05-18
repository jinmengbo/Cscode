using System;
using System.Collections.Generic;
using System.Text;

namespace Apithree
{
    /* 开始定义接口，来用虚方法实现接口成员。
     * 1. 首先先定义了接口,没有返回值的方法。
     * 2. 定义了一个类,继承了我们这个接口,然后我们在这个类下定义了一个方法,但是我们想让以后的类，继承我后，可以更改我下边的方法,然后我就加了一个virtual修饰符，说明别人继承了我这个类,可以重构我这个方法
     * 3. 我们又定义了一个类，继承了我们首先定义的类,然后又定义了一个方法,因为我们想重构我派生(继承)的类下边方法,所以必须要加入override这个修饰符,然后进行了重构。
     * 4. 显式实现的接口成员不能标识为virtual，也不能实现通常意义的重写，但是它可以被重新实现
     */
    interface IUndoable { void Undo(); }
    public class TextBox : IUndoable
    {
        public virtual void Undo() => Console.WriteLine("TextBOx.Undo");
    }
    public class RichTextBox : TextBox
    {
        public override void Undo() => Console.WriteLine("RichTextBox.Undo");


    }
}