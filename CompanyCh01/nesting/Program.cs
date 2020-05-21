using System;

namespace nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            // 例如，为了从TopLevel外访问Color.Red，我们必须写作：
            TopLeve1.Color color = TopLeve1.Color.Red;
            Console.WriteLine($"{color}");
        }
    }
}
