using System;

namespace nature
{
    class Program
    {
        // Get Set方法的使用,从第一个例子开始到最后表达式。
        //private double _seconds;
        //public double Houst
        //{
        //    get
        //    {
        //        return _seconds / 36;
        //    }
        //    set
        //    {
        //        if (value<0||value>24)
        //        {
        //            throw new ArgumentException(
        //                $"{nameof(value)} must be between 0 and 24.");
        //            _seconds = value * 36;

                    
        //        }
        //    }
        //}
        static void Main(string[] args)
        {
            //Program t = new Program();
            //t.Houst = 24;
            //Console.WriteLine($"Time in hours: {t.Houst}");
            //var tt = new TimePeriod("jin","mengbo");
            //Console.WriteLine(tt.name);
            //var item = new TimePeriod("jin", "mengbo");
            //Console.WriteLine($"{item.fileNmae}:{item.laseName}");
            var items = new TimePeriod();
            Console.WriteLine($"{items.Name="jin"}+{items.Price = "mengbo"}");


        }
    }
}
