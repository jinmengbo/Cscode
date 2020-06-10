using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class LibrayMockData
    {
        // 获取LibrayMockData实例
        public static LibrayMockData Current { get; } = new LibrayMockData();
        public List<AuthorDto> Authors { get; set; }
        public List<BookDto> Books { get; set; }
        public LibrayMockData()
        {
            Authors = new List<AuthorDto>
            {
                new AuthorDto{Id=new Guid("bd0b7a43-ea4e-4c16-a179-90c0d0003aa4"),Name="Author 1",Age=23,Email="1454440425@qq.com"},
                new AuthorDto{Id=new Guid("5203618d-439c-4a4d-8f8c-e253849aed70"),Name="Author 2",Age=24,Email="15890388831@163.com"}
            };
            Books = new List<BookDto>
            {
                new BookDto{
                    Id=new Guid("9e6c291d-d8a1-4b55-ba23-51b9bcb1efb0"),
                    Title="西游记 ",
                    Description="这是中国四大名著之一",
                    Pages=300,
                    AuthorId=new Guid("bd0b7a43-ea4e-4c16-a179-90c0d0003aa4")
                },
                new BookDto
                {
                    Id=new Guid("880f8f81-d194-46cd-9810-105cf2c9eca9"),
                    Title="红楼梦 ",
                    Description="这是中国四大名著之二",
                    Pages=325,
                    AuthorId=new Guid("bd0b7a43-ea4e-4c16-a179-90c0d0003aa4")
                },
                new BookDto
                {
                    Id=new Guid("2db224d3-9c3a-42f4-ac74-fe934d6af479"),
                    Title="三国演义 ",
                    Description="这是中国四大名著之三",
                    Pages=350,
                    AuthorId=new Guid("5203618d-439c-4a4d-8f8c-e253849aed70")
                },
                new BookDto
                {
                    Id=new Guid("0f0f5326-e614-4307-93f1-4fef48ecf480"),
                    Title="水浒传 ",
                    Description="这是中国四大名著之四",
                    Pages=375,
                    AuthorId=new Guid("5203618d-439c-4a4d-8f8c-e253849aed70")
                }
            };
        }
    }
}
