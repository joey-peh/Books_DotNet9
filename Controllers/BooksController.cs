using BookAPI_DotNet9.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI_DotNet9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //Using static to persist
        static private List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
            new Book { Id = 2, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
            new Book { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
            new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", YearPublished = 1813 },
            new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", YearPublished = 1951 },
            new Book { Id = 6, Title = "Moby-Dick", Author = "Herman Melville", YearPublished = 1851 },
            new Book { Id = 7, Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937 },
            new Book { Id = 8, Title = "War and Peace", Author = "Leo Tolstoy", YearPublished = 1869 },
            new Book { Id = 9, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", YearPublished = 1866 },
            new Book { Id = 10, Title = "The Odyssey", Author = "Homer", YearPublished = 800 },
            new Book { Id = 11, Title = "The Road", Author = "Cormac McCarthy", YearPublished = 2006 },
            new Book { Id = 12, Title = "Brave New World", Author = "Aldous Huxley", YearPublished = 1932 }
        };

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book is null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book book)
        {
            if (book is null)
            {
                return BadRequest();
            }
            books.Add(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        //IActionResult because we are only returning status code
        public IActionResult UpdateBook(int id, Book bookToUpdate)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book is null)
            {
                return NotFound();
            }
            book.Id = bookToUpdate.Id;
            book.Title = bookToUpdate.Title;
            book.Author = bookToUpdate.Author;
            book.YearPublished = bookToUpdate.YearPublished;  
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book is null)
            {
                return NotFound();
            }
            books.Remove(book);
            return NoContent(); 
        }
    }
}
