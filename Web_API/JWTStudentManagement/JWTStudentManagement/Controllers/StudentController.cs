using JWTStudentManagement.DTO;
using JWTStudentManagement.Services;
using JWTStudentManagement.DTO;
using JWTStudentManagement.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTStudentManagement.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentController(StudentService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentDTO dto)
        {
            _service.AddStudent(dto);
            return Ok("Student created");
        }

        [HttpPut]
        public IActionResult UpdateRoom(int studentId, int roomNo)
        {
            _service.UpdateRoom(studentId, roomNo);
            return Ok("Room updated");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.DeleteStudent(id);
            return Ok("Student deleted");
        }

        [HttpGet("hostelstudents")]
        public IActionResult HostelStudents()
        {
            return Ok(_service.GetHostelStudents());
        }

        [HttpGet]
        public IActionResult AllStudents()
        {
            return Ok(_service.GetAllStudents());
        }
    }
}