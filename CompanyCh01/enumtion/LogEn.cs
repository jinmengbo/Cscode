using System;
using System.Collections.Generic;
using System.Text;

namespace enumtion
{
    [Flags]
    public enum LogEn
    {
        None=0,
        left=1,
        Right=2,
        Top=4,
        Bottom=8
    }
}
