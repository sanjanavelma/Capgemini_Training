using LibrarySystem.Models;

namespace LibrarySystem.Repository
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        List<Book> GetBooksAbove500();
        Book GetBookByName(string name);
    }
}
