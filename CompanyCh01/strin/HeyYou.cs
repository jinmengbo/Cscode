using System;

namespace strin
{
    class Program
    {
        static void Main(string[] args)
        {
            // 这是c#6.0字符串格式化，以前用到的更多的是复合格式化
            // string fistName,lastNmae;
            // System.Console.Write("HeyYou");
            // System.Console.Write("回车：");
            // var fistName=System.Console.ReadLine();
            // System.Console.Write("再次回车");
            // var lastNmae=System.Console.ReadLine();
            // System.Console.WriteLine(
                // $"获取内容信息{fistName}{lastNmae}"
                // 下边是复合格式化写法
                // "获取到控制台的信息是{0}{1}",fistName,lastNmae
                // 有些情况下，我们复合格式化写法，可以不按照顺序排序编写。但是一定要写成对应。交换索引
                // "获取到控制台的内容是：{1}{0}",fistName,lastNmae
            // );
            (string country,string capital,double gdPerCapita)=
            ("jin","mengbo",80.25);
            System.Console.WriteLine(
                $@"@符号的作用就是为了换行后也属于同一个字符串
                {country},{capital}:{gdPerCapita}
            ");
        }
    }
}
