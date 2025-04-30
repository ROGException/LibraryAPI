using LibraryApi.Data;
using LibraryApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public BookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var books = await _dataContext.Books.ToListAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _dataContext.Books.FindAsync(id);
            if(book == null)
            {
                return NotFound("Hero not found");
            }
            return Ok(book);
        }
        [HttpPost]
        public async Task<ActionResult<List<Book>>> AddBook(Book book)
        {
             _dataContext.Books.Add(book);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Books.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Book>>> UpdateBook(Book updatedBook)
        {
            var dbBook = await _dataContext.Books.FindAsync(updatedBook.Id);
            if (dbBook == null)
            {
                return NotFound("Book not found");
            }

            dbBook.Title = updatedBook.Title;
            dbBook.Author = updatedBook.Author;
            dbBook.Pages = updatedBook.Pages;
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Books.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Book>>> DeleteBooks(int id)
        {
            var dbBook = await _dataContext.Books.FindAsync(id);
            if (dbBook == null)
            {
                return NotFound("Book not found");
            }
            _dataContext.Books.Remove(dbBook);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Books.ToListAsync());
        }

    }
}
