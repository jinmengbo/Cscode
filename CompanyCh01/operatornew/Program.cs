using System;
using System.Text;

namespace operatornew
{
    class Program
    {
        // 普通写法我们去做判断
        public static void Save(object data)
        {
            //if (data is string)
            //{
            //    string text = (string)data;
            //    if(text.Length>0)
            //    {
            //        data = Encoder(text);
            //    }

            //}
            //我们优化一下写成is模式匹配
            if (data is string text && text.Length>0)
            {
                data = Encoder(text);
            }
            else if (data==null)
            {
                throw new ArgumentNullException(nameof(data));
            }
        }

        private static object Encoder(string data)
        {
            return $"ENCRYPTED<{data}>ENCRYPTED";
        }

        static void Main(string[] args)
        {
          
        }
    }
}
