using System;
using System.Collections.Generic;
using System.Linq;

namespace threeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1 };
            IEnumerable<int> query = numbers.Select(n => n * 10);
            numbers.Add(2);
            foreach (int item in query)
            {
                Console.WriteLine(item +"|");
            }
            string[] musos = { "David Gilmour", "Roget Waters", "Rick Wright", "Nick Mason" };
            //IEnumerable<string> que = musos.OrderBy(m => m.Split().Last());
            //IEnumerable<string> outerQuery = 
                //musos.Where(n => n.Length == musos.OrderBy(n1 => n1.Length).Select(n1 => n1.Length).First());
            IEnumerable<string> outerQuery=from  n in musos where n.Length==musos.Min(n1=>n1.Length)select n;
            foreach (var item in outerQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
