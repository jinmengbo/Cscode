namespace ApiOne
{
    public class PubLication: IListable
    {
        // 我们还是定义三个方法，这时候我们可以看出来，我们继承一个接口可以在两个类实现一样的事情。
        public PubLication(string tile, string author, double year)
        {
            Title = tile;
            Author = author;
            Year = year;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public  double Year { get; set; }

        public string[] ColumnValues
        {
            get
            {
                return new  string[]
                {
                    Title,
                    Author,
                    // 这是一个去除字符串的操作。
                    Year.ToString()
                };
            }
        }

        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "Title                ",
                    "Author               ",
                    "Year                 "
                };
            }
        }
    }
}