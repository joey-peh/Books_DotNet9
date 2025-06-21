using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookAPI_DotNet9.Migrations
{
    /// <inheritdoc />
    public partial class Addbookdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "The Great Gatsby", 1925 },
                    { 2, "George Orwell", "1984", 1949 },
                    { 3, "Harper Lee", "To Kill a Mockingbird", 1960 },
                    { 4, "Jane Austen", "Pride and Prejudice", 1813 },
                    { 5, "J.D. Salinger", "The Catcher in the Rye", 1951 },
                    { 6, "Herman Melville", "Moby-Dick", 1851 },
                    { 7, "J.R.R. Tolkien", "The Hobbit", 1937 },
                    { 8, "Leo Tolstoy", "War and Peace", 1869 },
                    { 9, "Fyodor Dostoevsky", "Crime and Punishment", 1866 },
                    { 10, "Homer", "The Odyssey", 800 },
                    { 11, "Cormac McCarthy", "The Road", 2006 },
                    { 12, "Aldous Huxley", "Brave New World", 1932 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
