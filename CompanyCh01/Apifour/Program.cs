using System;

namespace Apifour
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTextBox readTextBox = new ReadTextBox();
            //readTextBox.Undo();
            ((IUndoable)readTextBox).Undo();
            //((TextBox)readTextBox).Undo();

        }
    }
}
