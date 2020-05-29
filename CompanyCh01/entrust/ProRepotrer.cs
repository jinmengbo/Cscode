using System;
using System.Collections.Generic;
using System.Text;

namespace entrust
{
    public delegate void ProRepo(int p);
    class ProRepotrer
    {
        public void Instance(int p) => Console.WriteLine(p);
    }
}
