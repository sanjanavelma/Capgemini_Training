using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApplication1.Models;
using System.Data;
namespace WebApplication1.Controllers
{
    public class SportsController : Controller
    {
        private readonly IConfiguration _configuration;

        public SportsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 5;
            List<Sport> sports = new List<Sport>();

            string conn = _configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("GetSportsPaged", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PageNumber", page);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sports.Add(new Sport
                    {
                        id = Convert.ToInt32(reader["id"]),
                        Name = reader["Name"].ToString(),
                        SportName = reader["SportName"].ToString()
                    });
                }
            }
            int totalRecords = 30; // since you know you inserted 30 rows
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            PagedSports model = new PagedSports
            {
                Sports = sports,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(model);
        }
    }
}
