﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/authors/{authorId}/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public IAuthorRepository AuthorRepository { get; }

        public IBookRepository BookRepository { get; }
        public BookController(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            AuthorRepository = authorRepository;
            BookRepository = bookRepository;
        }
        [HttpGet]
        public ActionResult<List<BookDto>> GetBooks(Guid authorId)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            return BookRepository.GetBooksForAuthor(authorId).ToList();
        }
        [HttpGet("{bookId}", Name = nameof(GetBook))]
        public ActionResult<BookDto> GetBook(Guid authorId, Guid bookId)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            var targetBook = BookRepository.GetBookForAuthor(authorId, bookId);
            if (targetBook == null)
            {
                return NotFound();

            }
            return targetBook;
        }
        [HttpPost]
        public IActionResult AddBook(Guid authorId, BookForCreationDto bookForCreationDto)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            var newBook = new BookDto
            {
                Id = Guid.NewGuid(),
                Title = bookForCreationDto.Title,
                Description = bookForCreationDto.Description,
                Pages = bookForCreationDto.Pages,
                AuthorId = authorId,
            };
            BookRepository.AddBook(newBook);
            return CreatedAtRoute(nameof(GetBook), new { authorId = authorId, bookId = newBook.Id, }, newBook);
        }
        [HttpDelete]
        public IActionResult DeleteBook(Guid authorId,Guid bookId)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            var book = BookRepository.GetBookForAuthor(authorId, bookId);
            if (book == null)
            {
                return NotFound();
            }
            BookRepository.DeleteBook(book);
            return NoContent();
        }
        [HttpPut("bookId")]
        public IActionResult UpdataBokk(Guid authorId, Guid bookId, BookForUpdataDto updatebook)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            var book = BookRepository.GetBookForAuthor(authorId, bookId);
            if (book == null)
            {
                return NotFound();
            }
            BookRepository.UpadataBook(authorId, bookId, updatebook);
            return NoContent();
        }
        [HttpPatch("{bookId}")]
        public IActionResult PartiallyUpdateBook(Guid authorId,Guid bookId, JsonPatchDocument<BookForUpdataDto> patchDocument)
        {
            if (!AuthorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            var book = BookRepository.GetBookForAuthor(authorId, bookId);
            if (book == null)
            {
                return NotFound();
            }
            var bookToPatch = new BookForUpdataDto
            {
                Title = book.Title,
                Description = book.Description,
                Pages = book.Pages
            };
            patchDocument.ApplyTo(bookToPatch);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            BookRepository.UpadataBook(authorId, bookId, bookToPatch);
            return NoContent();
        }
    }
}