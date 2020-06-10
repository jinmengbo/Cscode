using System;
using System.Linq;

namespace Extensionmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 56, 45, 78, 28, 18 };
            var result = ints.OrderBy(g => g);
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            var dou = new { name = "jinjin", age = 20 };
            var d = dou.name;
            Console.WriteLine(d);
            


            
        }
    }
}
