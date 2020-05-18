using System;

namespace ApiOne

{
    // 因为我们供方那边，定义的是一个列表，所以我们在下边定义一个循环方法,把我们上边填写的列表信息打印出来。
     class ConsoleListContol
    {
        public static void List(string[] headers,IListable[] items)
        {
            int[] columnWiddths = DispLayHeaders(headers);
            for (int count = 0; count < items.Length; count++)
            {
                string[] values = items[count].ColumnValues;
                DisplayItemRow(columnWiddths,values);
            }
        }

        private static int[] DispLayHeaders(string[] headers)
        {
            var columnWidths = new int[headers.Length];
            for(int index = 0; index < headers.Length; index++)
            {
                Console.Write(headers[index]);
                columnWidths[index] = headers[index].Length;
            }
            Console.WriteLine();
            return columnWidths;
        }

        private static void DisplayItemRow(int[] columnWidths, string[] values)
        {
            if(columnWidths.Length != values.Length)
            {
                throw new ArgumentOutOfRangeException(
                    $"{ nameof(columnWidths) },{ nameof(values) }",
                    "The number of column widths must match the number of values to print");
            }

            for(int index = 0; index < values.Length; index++)
            {
                string itemToPrint = values[index].PadRight(columnWidths[index], ' ');
                Console.Write(itemToPrint);
            }
            Console.WriteLine();
        }
    }
}