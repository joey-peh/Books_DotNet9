using BookAPI_DotNet9.Data;
using BookAPI_DotNet9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPI_DotNet9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseBooksController : ControllerBase
    {
        private readonly BookDbContext _context;
        public DatabaseBooksController(BookDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            var books = await _context.Books.ToListAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            if (book is null)
            {
                return BadRequest();
            }
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        //IActionResult because we are only returning status code
        public async Task<IActionResult> UpdateBook(int id, Book bookToUpdate)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            book.Id = bookToUpdate.Id;
            book.Title = bookToUpdate.Title;
            book.Author = bookToUpdate.Author;
            book.YearPublished = bookToUpdate.YearPublished;

            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
