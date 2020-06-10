using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "jinmengbo", "nan", "23sui", "hanzu" };
            IEnumerable<string> enumerable =
                from n in names
                where n.Contains("n")
                orderby n.Length
                select n.ToUpper();

            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
    
        }
    }
}
