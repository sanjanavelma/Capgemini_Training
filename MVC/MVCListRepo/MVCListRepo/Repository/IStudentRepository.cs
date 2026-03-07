using MVCListRepo.Models;

namespace MVCListRepo.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
    }
}
