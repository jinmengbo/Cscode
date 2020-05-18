using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Text;

namespace nature
{
   public class TimePeriod
    {
        //public string FileName;
        //public string LasenName;
        //public TimePeriod (string fileNmae,string laseName)
        //{
        //    FileName = fileNmae;
        //    LasenName = laseName;
        //}
        //public string fileNmae { get => FileName; set => FileName = value; }
        //public string laseName { get => LasenName; set => LasenName = value; }
        //public string name => $"{FileName}{LasenName}";
        // 自动实现的方法,作用和上边方法一致。
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
