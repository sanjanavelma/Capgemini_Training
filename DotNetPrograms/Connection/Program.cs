 using System;
 using System.Data.SqlClient; // Use Microsoft.Data.SqlClient for modern .NET
using System.Data;
using System.Reflection.PortableExecutable;
using Microsoft.Data.SqlClient;

// class Program
// {
//     static void Main()
//     {
//         // 1. Define the connection string
//         // Replace [ServerName] and [DatabaseName] with your actual SQL Server details.
//         // Use "Trusted_Connection=True" for Windows Authentication (integrated security)
//         // or "User Id=myUsername;Password=myPassword;" for SQL Server Authentication.
// string connectionString = "Data Source=localhost\\SQLEXPRESS;" +"Initial Catalog=College;" +"Integrated Security=True;" + "Encrypt=True;" +
//     "TrustServerCertificate=True;";

//         // 2. Create a SqlConnection object within a 'using' statement
//         // The 'using' statement ensures the connection is automatically closed and disposed
//         // even if errors occur.
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             try
//             {
//                 // 3. Open the connection
//                 connection.Open();
//                 Console.WriteLine("Connection successful!");

//                 // 4. Define and execute a SQL command
//                 string query = "SELECT Name,Department from CollegeMaster1";

//                 using (SqlCommand command = new SqlCommand(query, connection))
//                 {
//                     SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
//                     // Use parameters to prevent SQL injection
//                     SqlCommandBuilder sqlee = new SqlCommandBuilder(dataAdapter);


//                     // Use SqlDataReader to read data from the database
//                     using (SqlDataReader reader = command.ExecuteReader())
//                     {
//                         Console.WriteLine("\nReading data...");
//                         while (reader.Read())
//                         {
//                             // Access data by column name or index
//                             Console.WriteLine($"{reader["Name"]} {reader["Department"]}");
//                         }
//                     }
//                 }
//             }
//             catch (SqlException ex)
//             {
//                 // Handle any errors that may occur during the connection or query
//                 Console.WriteLine($"Error: {ex.Message}");
//             }
//             // The connection is implicitly closed when the 'using' block ends (even in case of error)
//             Console.WriteLine("Connection closed.");
//             Hyy();
//         }
//     }

//     private static void Hyy()
//     {
//     }
// }
//--------------------------------------------------------------------------------------------------------------
// class Program
// {
//     static void Main()
//     {
//         EmployeeRepository repo = new EmployeeRepository();

//         Console.Write("Enter salary limit: ");

//         if (int.TryParse(Console.ReadLine(), out int limit))
//         {
//             repo.GetEmployeesAboveSalary(limit);
//         }
//         else
//         {
//             Console.WriteLine("Invalid salary input.");
//         }
//     }
// }
//------------------------------------------------------------------------------------------------------------------------------------
// class Program
// {
//     static void Main()
//     {
//         EmployeeRepository repo = new EmployeeRepository();

//         Console.Write("Enter salary limit: ");

//         if (int.TryParse(Console.ReadLine(), out int salary))
//         {
//             repo.GetEmployeesAboveSalary(salary);
//         }
//         else
//         {
//             Console.WriteLine("Invalid input.");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         EmployeeRepository repo = new EmployeeRepository();

//         repo.GetEmployeesAboveSalary(50000, 3);
//     }
// }
//-------------------------------------------------------------------------------------------------------------------------
// class Program
// {
//     static string connectionString =
//         "Server=.\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;";

//     static void Main()
//     {
//         Console.Write("Enter gender: ");
//         string gender = Console.ReadLine();

//         using (SqlConnection con = new SqlConnection(connectionString))
//         using (SqlCommand cmd = new SqlCommand("uspGetGenderCount", con))
//         {
//             cmd.CommandType = System.Data.CommandType.StoredProcedure;

//             // input parameter
//             cmd.Parameters.AddWithValue("@gender", gender);

//             // output parameter
//             SqlParameter outputParam = new SqlParameter("@count", System.Data.SqlDbType.Int);
//             outputParam.Direction = System.Data.ParameterDirection.Output;
//             cmd.Parameters.Add(outputParam);

//             con.Open();
//             cmd.ExecuteNonQuery();

//             int result = (int)outputParam.Value;

//             Console.WriteLine($"Count of {gender}: {result}");
//         }
//     }
// }
//---------------------------------------------------------------------------------------------------------------------
// using System;
// using Microsoft.Data.SqlClient;
// using System.Data;

// class Program
// {
//     static string cs = "Server=.\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;";

//     static void Main()
//     {
//         using (SqlConnection con = new SqlConnection(cs))
//         {
//             con.Open();
//             SqlCommand countCmd = new SqlCommand(
//                 @"SELECT COUNT(*)
//                   FROM Students s
//                   JOIN Hostel1 h
//                   ON s.id = h.CollegeId", con);

//             int hostelCount = (int)countCmd.ExecuteScalar();

//             Console.WriteLine("Hostel student count: " + hostelCount);

//             if (hostelCount > 5)
//             {
//                 SqlCommand deleteCmd = new SqlCommand(
//                     @"DELETE s
//                       FROM Students s
//                       JOIN Hostel1 h
//                       ON s.id = h.CollegeId
//                       WHERE s.M1 = 100 OR s.M2 = 100 OR s.M3 = 100", con);

//                 int rowsDeleted = deleteCmd.ExecuteNonQuery();

//                 Console.WriteLine("Deleted topper students: " + rowsDeleted);
//             }
//             else
//             {
//                 Console.WriteLine("No deletion needed.");
//             }

//             SqlCommand readCmd =
//                 new SqlCommand("SELECT * FROM Students", con);

//             using (SqlDataReader reader = readCmd.ExecuteReader())
//             {
//                 Console.WriteLine("\nAll Students:");

//                 while (reader.Read())
//                 {
//                     Console.WriteLine(
//                         $"{reader["id"]} | {reader["Name"]} | " +
//                         $"M1:{reader["M1"]} M2:{reader["M2"]} M3:{reader["M3"]} | " +
//                         $"Total:{reader["Total"]}");
//                 }
//             }
//         }
//     }
// }

//---------------------------------------------------------------------------------------------------------------------

// class Program
// {
//     static void Main()
//     {
//         string connectionString = "Server=.\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;";
//         using(SqlConnection connection = new SqlConnection(connectionString))
//         {
//             connection.Open();
//             Console.WriteLine("Connection successfull!");
//             string query = "Select dbo.FnSquare(@num)";
//             using(SqlCommand command = new SqlCommand(query, connection))
//             {
//                 command.CommandType = CommandType.Text;
//                 command.Parameters.AddWithValue("@num", 6);
//                 int square = Convert.ToInt32(command.ExecuteScalar());
//                 Console.WriteLine("Square: " + square);
//             }
//         }
//     }
// }
//----------------------------------------------------------------------------------------------------------------------------

// class Program
// {
//     static void Main()
//     {
//         string cs =
//             "Server=.\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;";

//         try
//         {
//             using (SqlConnection con = new SqlConnection(cs))
//             {
//                 con.Open();
//                 Console.WriteLine("Connected!");

//                 string query = "SELECT * FROM dbo.FnMultiplyMarks()";

//                 using (SqlCommand cmd = new SqlCommand(query, con))
//                 using (SqlDataReader reader = cmd.ExecuteReader())
//                 {
//                     Console.WriteLine("\nStudent Multiplication Results:");

//                     while (reader.Read())
//                     {
//                         Console.WriteLine(
//                             $"{reader["id"]} | {reader["Name"]} | " +
//                             $"M1:{reader["M1"]} M2:{reader["M2"]} | " +
//                             $"M1*M2 = {reader["MultiplyMarks"]}");
//                     }
//                 }
//             }
//         }
//         catch (SqlException ex)
//         {
//             Console.WriteLine("SQL Error: " + ex.Message);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("General Error: " + ex.Message);
//         }
//     }
// }
//-----------------------------------------------------------------------------------------------------------------------

// class Program
// {
//     static void Main()
//     {
//         string connectionString = "Server=.\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;";
//         DataSet ds = new DataSet();
//         try
//         {
//             using (SqlConnection connection = new SqlConnection(connectionString))
//             {
//                 connection.Open();
//                 Console.WriteLine("Connection Successful!");
//                 using (SqlCommand command = new SqlCommand("sp_GetStudents", connection))
//                 {
//                     command.CommandType = CommandType.StoredProcedure;
//                     SqlDataAdapter adapter = new SqlDataAdapter(command);
//                     adapter.Fill(ds, "Students");
//                 }
//             }
//             DataTable table = ds.Tables["Students"];
//             foreach (DataRow row in table.Rows)
//             {
//                 Console.WriteLine(
//                     $"{row["id"]} | {row["Name"]} | {row["Department"]} | {row["M1"]}");
//             }

//             Console.WriteLine("Rows loaded: " + ds.Tables["Students"].Rows.Count);
//         }
//          catch (SqlException ex)
//         {
//             Console.WriteLine("SQL Error: " + ex.Message);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("General Error: " + ex.Message);
//         }
//     }

// }

//----------------------------------------------------------------------------------------------------------------
// class Program
// {
//     static void Main()
//     {
//         string connectionString = "Server=.\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;";
//         DataTable dt = new DataTable();
//         DataSet ds = new DataSet();
//         dt.Columns.Add("Id", typeof(int));
//         dt.Columns.Add("Name", typeof(string));
//         dt.Columns.Add("Department", typeof(string));
//         dt.Rows.Add(1, "Mahima", "IT");
//         dt.Rows.Add(2, "Marimuthu", "MCA");
//         dt.Rows.Add(3, "Ritik", "ECE");
//         Console.WriteLine("Student Details:");
//         foreach(DataRow row in dt.Rows)
//         {
//             Console.WriteLine($"{row["Id"]} - {row["Name"]} - {row["Department"]}");
//         }
//         ds.Tables.Add(dt);
//         Console.WriteLine(ds.Tables.Count);
//         }
// }
//------------------------------------------------------------------------------------------------------------

// using System;
// using System.Data.SqlClient;
// using System.Diagnostics;

// class Program
// {
//     static void Main()
//     {
//         string cs = "Server=.\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;";

//         Stopwatch sw = Stopwatch.StartNew();

//         for (int i = 0; i < 100; i++)
//         {
//             using (SqlConnection con = new SqlConnection(cs))
//             {
//                 con.Open();

//                 using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Students", con))
//                 {
//                     int count = (int)cmd.ExecuteScalar();
//                 }
//             }
//         }

//         sw.Stop();

//         Console.WriteLine("\nTotal Time: " + sw.ElapsedMilliseconds + " ms");
//     }
// }

//-------------------------------------------------------------------------------------------------------------

class Program
{
    static void Main()
    {
        string cs = "Server=.\\SQLEXPRESS;Database=College;Trusted_Connection=True;TrustServerCertificate=True;";

        Stopwatch sw = Stopwatch.StartNew();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Students", con))
            {
                for (int i = 0; i < 100; i++)
                {
                    int count = (int)cmd.ExecuteScalar();
                }
            }
        }

        sw.Stop();

        Console.WriteLine("\nTotal Time: " + sw.ElapsedMilliseconds + " ms");
    }
}




