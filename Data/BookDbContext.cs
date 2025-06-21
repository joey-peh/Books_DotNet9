using BookAPI_DotNet9.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI_DotNet9.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
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
            new Book { Id = 12, Title = "Brave New World", Author = "Aldous Huxley", YearPublished = 1932 });
        }
        public DbSet<Book> Books {get;set;}
    }
}
