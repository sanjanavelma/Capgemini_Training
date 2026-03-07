using LibrarySystem.Models;

namespace LibrarySystem.Repository
{
    public class DictionaryBookRepository : IBookRepository
    {
        private Dictionary<int, Book> books = new Dictionary<int, Book>()
        {
            {1, new Book{Id=1, Name="C Programming", Author="Dennis Ritchie", Price=450}},
            {2, new Book{Id=2, Name="Clean Code", Author="Robert Martin", Price=700}},
            {3, new Book{Id=3, Name="Java Basics", Author="James Gosling", Price=550}},
            {4, new Book{Id=4, Name="Python Guide", Author="Guido", Price=300}}
        };

        public List<Book> GetAllBooks()
        {
            return books.Values.ToList();
        }

        public List<Book> GetBooksAbove500()
        {
            return books.Values.Where(b => b.Price > 500).ToList();
        }

        public Book GetBookByName(string name)
        {
            return books.Values.FirstOrDefault(b => b.Name == name);
        }
    }
}
