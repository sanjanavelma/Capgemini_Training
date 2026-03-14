using DTOMiniPro.DTO;
using DTOMiniPro.Services;
using DTOMiniPro.DTO;
using DTOMiniPro.Services;
using Microsoft.AspNetCore.Mvc;

namespace DTOMiniPro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentController(StudentService service)
        {
            _service = service;
        }

        // Create student
        [HttpPost]
        public IActionResult CreateStudent(StudentDTO dto)
        {
            _service.AddStudent(dto);
            return Ok("Student created and hostel assigned");
        }

        // Update room
        [HttpPut("updateroom")]
        public IActionResult UpdateRoom(int studentId, int roomNo)
        {
            _service.UpdateRoom(studentId, roomNo);
            return Ok("Room updated");
        }

        // Delete student
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteStudent(id);
            return Ok("Student deleted");
        }

        // Read hostel students
        [HttpGet("hostelstudents")]
        public IActionResult GetHostelStudents()
        {
            return Ok(_service.GetHostelStudents());
        }

        // Read all college students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_service.GetAllStudents());
        }
    }
}