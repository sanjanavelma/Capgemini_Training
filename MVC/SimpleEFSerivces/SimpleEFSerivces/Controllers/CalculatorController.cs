using Microsoft.AspNetCore.Mvc;
using SimpleEFSerivces.Services;

namespace SimpleEFSerivces.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorService _calculator;
        public CalculatorController(CalculatorService calculator)
        {
            _calculator = calculator;
        }
        public IActionResult Add()
        {
            int result = _calculator.add(5, 3);
            return Content("Result = " + result);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
