using System.Collections.Generic;
namespace WebApplication1.Models
{
    public class PagedSports
    {
        public List<Sport> Sports { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
