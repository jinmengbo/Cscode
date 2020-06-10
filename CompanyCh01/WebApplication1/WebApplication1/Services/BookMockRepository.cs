using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    
    public class BookMockRepository:IBookRepository
    {
        public BookDto GetBookForAuthor(Guid authorId,Guid bookId)
        {
            return LibrayMockData.Current.Books.FirstOrDefault(b => b.AuthorId == authorId && b.Id == bookId);
        }
        public IEnumerable<BookDto>GetBooksForAuthor(Guid authorId)
        {
            return LibrayMockData.Current.Books.Where(b => b.AuthorId == authorId).ToList();
        }
        public void AddBook(BookDto book)
        {
            LibrayMockData.Current.Books.Add(book);
        }
        public void DeleteBook(BookDto book)
        {
            LibrayMockData.Current.Books.Remove(book);
        }
        public void UpadateBook(Guid authorId, Guid bookId, BookForUpdataDto book)
        {
            var originalBook = GetBookForAuthor(authorId, bookId);
            originalBook.Title = book.Title;
            originalBook.Pages = book.Pages;
            originalBook.Description = book.Description;
        }
    }
}
