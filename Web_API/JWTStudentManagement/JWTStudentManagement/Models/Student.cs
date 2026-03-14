namespace JWTStudentManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int HostelId { get; set; }

        public Hostel Hostel { get; set; }
    }
}