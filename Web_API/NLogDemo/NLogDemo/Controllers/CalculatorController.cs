using Microsoft.AspNetCore.Mvc;

namespace NLogDemo.Controllers
{
    [ApiController]
    [Route("api/calculator")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            _logger.LogInformation("Add method called with {A} and {B}", a, b);

            int result = a + b;

            _logger.LogInformation("Addition result: {Result}", result);

            return Ok(result);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b)
        {
            _logger.LogInformation("Multiply method called with {A} and {B}", a, b);

            int result = a * b;

            _logger.LogInformation("Multiplication result: {Result}", result);

            return Ok(result);
        }
    }
}