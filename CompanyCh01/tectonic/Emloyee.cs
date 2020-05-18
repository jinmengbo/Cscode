using System;
using System.Collections.Generic;
using System.Text;

namespace tectonic
{
    class Emloyee
    {
        public Emloyee(string firstName, string lastName)
            {
            FirstName = firstName;
            LastName = lastName;
            }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Null";
    }
}
