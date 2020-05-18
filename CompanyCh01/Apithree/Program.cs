using System;

namespace Apithree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. 不管从基类还是接口中调用接口成员，调用的都是子类的实现,我们可以从下边这几个调用方法看出来。 
             * 2. 实例化了类，让richTextBox拥有了RichTextBox它的权限。 
             * 3. 然后，通过richTextBox这个方法调用了.Undo看一下输出的是什么
             * 4. 再通过继承的基类,调用Undo方法看看输出是什么
             * 5. 再通过接口，调用undo方法看看输出是什么
             * 6. 结论就是他们的输出都是RichTextBox.Und。
             * 7. 重点重点：显式实现的接口成员不能标识为virtual，也不能实现我们这种方法的重写，但是它可以被重新实现。
             */
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Undo();
            ((TextBox)richTextBox).Undo();
            ((IUndoable)richTextBox).Undo();


        }
    }
}
