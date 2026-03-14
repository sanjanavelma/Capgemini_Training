using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.DTOs;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>();

        // POST
        [HttpPost("createStudent")]
        public IActionResult CreateStudent([FromBody] CreateStudentDTO dto)
        {
            Student s = new Student
            {
                Id = dto.Id,
                Name = dto.Name,
                Age = dto.Age
            };

            students.Add(s);

            return Ok("Student Created Successfully");
        }

        // PUT
        [HttpPut("updateStudent")]
        public IActionResult UpdateStudent([FromBody] UpdateStudentDTO dto)
        {
            var student = students.FirstOrDefault(x => x.Id == dto.Id);

            if (student == null)
                return NotFound("Student not found");

            student.M1 = dto.M1;
            student.M2 = dto.M2;
            student.Total = dto.M1 + dto.M2;

            if (student.Total >= 90)
                student.Grade = "A";
            else if (student.Total >= 70)
                student.Grade = "B";
            else if (student.Total >= 50)
                student.Grade = "C";
            else
                student.Grade = "Fail";

            return Ok("Marks Updated");
        }

        // GET
        [HttpGet("GetResultById/{id}")]
        public IActionResult GetResultById(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound("Student not found");

            GetResultDTO result = new GetResultDTO
            {
                Id = student.Id,
                Name = student.Name,
                M1 = student.M1,
                M2 = student.M2,
                Total = student.Total,
                Grade = student.Grade
            };

            return Ok(result);
        }
    }
}