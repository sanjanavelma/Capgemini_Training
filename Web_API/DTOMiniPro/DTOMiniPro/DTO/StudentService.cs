using DTOMiniPro.DTO;
using DTOMiniPro.Models;
using DTOMiniPro.DTO;
using Microsoft.EntityFrameworkCore;

namespace DTOMiniPro.Services
{
    public class StudentService
    {
        private readonly CollegeDbContext _context;

        public StudentService(CollegeDbContext context)
        {
            _context = context;
        }

        // Create Student + Hostel
        public void AddStudent(StudentDTO dto)
        {
            Hostel hostel = new Hostel
            {
                RoomNo = dto.RoomNo
            };

            _context.Hostels.Add(hostel);
            _context.SaveChanges();

            Student student = new Student
            {
                Name = dto.Name,
                HostelId = hostel.HostelId
            };

            _context.Students.Add(student);
            _context.SaveChanges();
        }

        // Update Room No
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

        // Read all hostel students
        public List<Student> GetHostelStudents()
        {
            return _context.Students
                .Include(s => s.Hostel)
                .ToList();
        }

        // Read all college students
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
    }
}