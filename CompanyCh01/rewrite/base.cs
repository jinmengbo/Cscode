using System;
using System.Collections.Generic;
using System.Text;

namespace rewrite
{
    public class Base
    {
        public string StreetAddress;
        public string City;
        public string State;
        public string Zip;
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
