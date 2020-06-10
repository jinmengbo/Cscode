using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AuthorMockRepository: IAuthorRepository
    {
        public AuthorDto GetAuthor(Guid authorId)
        {
            var author = LibrayMockData.Current.Authors.FirstOrDefault(au => au.Id ==authorId);
            return author;
        }
        public IEnumerable<AuthorDto> GetAuthors()
        {
            return LibrayMockData.Current.Authors;
        }
        public bool IsAuthorExists(Guid authorId)
        {
            return LibrayMockData.Current.Authors.Any(au => au.Id == authorId);
        }
        public void AddAuthor(AuthorDto author)
        {
            author.Id = Guid.NewGuid();
            LibrayMockData.Current.Authors.Add(author);
        }
        public void DeleteAuthor(AuthorDto author)
        {
            LibrayMockData.Current.Books.RemoveAll(book => book.AuthorId == author.Id);
            LibrayMockData.Current.Authors.Remove(author);
        }
    }
}
