using JWTStudentManagement.Data;
using JWTStudentManagement.DTO;
using JWTStudentManagement.Models;
using JWTStudentManagement.Data;
using JWTStudentManagement.DTO;
using JWTStudentManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTStudentManagement.Services
{
    public class StudentService
    {
        private readonly CollegeDbContext _context;

        public StudentService(CollegeDbContext context)
        {
            _context = context;
        }

        // Create student + hostel
        public void AddStudent(StudentDTO dto)
        {
            var hostel = new Hostel
            {
                RoomNo = dto.RoomNo
            };

            _context.Hostels.Add(hostel);
            _context.SaveChanges();

            var student = new Student
            {
                Name = dto.Name,
                HostelId = hostel.HostelId
            };

            _context.Students.Add(student);
            _context.SaveChanges();
        }

        // Update Room
        public void UpdateRoom(int studentId, int roomNo)
        {
            var student = _context.Students.Find(studentId);

            if (student == null) return;

            var hostel = _context.Hostels.Find(student.HostelId);

            hostel.RoomNo = roomNo;

            _context.SaveChanges();
        }

        // Delete Student
        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null) return;

            _context.Students.Remove(student);

            _context.SaveChanges();
        }

        // All hostel students
        public List<Student> GetHostelStudents()
        {
            return _context.Students.Include(x => x.Hostel).ToList();
        }

        // All college students
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
    }
}