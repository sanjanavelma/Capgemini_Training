using LibrarySystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository repo;

        public BookController(IBookRepository repository)
        {
            repo = repository;
        }

        // Show all books
        public IActionResult Index()
        {
            var books = repo.GetAllBooks();
            return View(books);
        }

        // Books above 500
        public IActionResult Above500()
        {
            var books = repo.GetBooksAbove500();
            return View(books);
        }

        // Search page
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string name)
        {
            var book = repo.GetBookByName(name);
            return View("Result", book);
        }
    }
}
