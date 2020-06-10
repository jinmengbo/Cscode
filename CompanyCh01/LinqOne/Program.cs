using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOne
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] names = { "jinmengbo", "nan", "age", "hanzu" };
            //IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);
            //IEnumerable<string> filteredNames = names.Where(n => n.Length >= 6);
            //var filteredNames = names.Where(j => j.Length >= 7);
            //IEnumerable<string> filteredNames = names.Where(n => n.Contains("n"));
            //foreach (var item in filteredNames)
            //{
            //    Console.WriteLine(item);
            //}
            //var filteredNames = from n in names where n.Contains("n") select n;
            IEnumerable<string> query =
                // 判断里边是否有n字母
                names.Where(n => n.Contains("n"))
                // 进行从小到大排序
                .OrderBy(n => n.Length)
                // 转成大写形式。
                .Select(n => n.ToUpper());
            foreach (var item in query) Console.WriteLine(item);
            IEnumerable<int> que = names.Select(n => n.Length);
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            // Take运算符将输出前x个元素，而丢弃其他元素
            int[] numbers = { 10, 9, 8, 7, 6, 5 };
            IEnumerable<int> firstThree = numbers.Take(3);
            foreach (var item in firstThree) Console.WriteLine(item);
            // Skip运算符会跳过集合中的前x个元素而输出剩余的元素
            IEnumerable<int> LastTwo = numbers.Skip(3);
            foreach (var item in LastTwo) Console.WriteLine(item);
            // Reverse运算符会将集合中的所有元素反转，这和它的命名是一致的
            IEnumerable<int> reversed = numbers.Reverse();
            foreach (var item in reversed) Console.WriteLine(item);
            int[] seq1 = { 1, 2, 3, 4 };
            int[] seq2 = { 4, 5, 6, 7 };
            // Concat运算符会将一个输入序列附加到另一个序列后面，
            IEnumerable<int> concat = seq1.Concat(seq1);
            foreach (var item in concat) Console.WriteLine(item);
            // 而Union运算符除了附加之外还会去掉其中重复的元素：
            IEnumerable<int> union = seq1.Union(seq2);
            foreach (var item in union) Console.WriteLine(item);

        }

    }
}
