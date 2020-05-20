using System;
using System.Collections.Generic;
using System.Text;

namespace StuactOne
{
    public struct MutaBlePoint
    {
        public int X;
        public int Y;
        public MutaBlePoint(int x, int y) => (X, Y) = (x, y);
        public override string ToString() => $"{X},{Y}";
    }
}
