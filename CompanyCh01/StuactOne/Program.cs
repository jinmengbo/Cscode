using System;

namespace StuactOne
{
    struct Angle
    {
        public Angle(double x ,double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString() => $"{X}{Y}";
       
            

    }
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            angle.X = 5;
            angle.Y = 10;
            Console.WriteLine(angle);
            var p1 = new MutaBlePoint(1,2);
            var p2 = p1;
            p2.Y = 200;
            Console.WriteLine($"{nameof(p1)} after{nameof(p2)}is modfied:{p1}");
            Console.WriteLine($"{nameof(p2)}:{p2}");
            MutateAndDisplay(p2);
            Console.WriteLine($"MutateAndDisplay{nameof(MutateAndDisplay)},{nameof(p2)},{p2}");
        }
        private static void MutateAndDisplay(MutaBlePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in a method:{p}");
        }

    }
}
