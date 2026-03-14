using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOddSum()
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            return Ok(new
            {
                message = "Sum of odd numbers from 1 to 100",
                result = sum
            });
        }
    }
}