namespace JWTStudentManagement.Models
{
    public class Hostel
    {
        public int HostelId { get; set; }

        public int RoomNo { get; set; }

        public Student Student { get; set; }
    }
}
