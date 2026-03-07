using LibrarySystem.Data;
using LibrarySystem.Models;

namespace LibrarySystem.Repository
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly AppDbContext context;

        public SqlBookRepository(AppDbContext db)
        {
            context = db;
        }

        public List<Book> GetAllBooks()
        {
            return context.Books.ToList();
        }

        public List<Book> GetBooksAbove500()
        {
            return context.Books.Where(b => b.Price > 500).ToList();
        }

        public Book GetBookByName(string name)
        {
            return context.Books.FirstOrDefault(b => b.Name == name);
        }
    }
}
