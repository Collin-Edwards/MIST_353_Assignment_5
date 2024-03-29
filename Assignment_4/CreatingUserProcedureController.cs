using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;


namespace CreateUser_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatingUserProcedureController : ControllerBase
    {
        private readonly string _connectionString;

        public CreatingUserProcedureController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] RegisterUserRequest request)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("registeruser", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", request.Username);
                command.Parameters.AddWithValue("@passwordhash", request.PasswordHash);
                command.Parameters.AddWithValue("@email", request.Email);
                command.Parameters.AddWithValue("@isdoduser", request.IsDodUser);
                command.Parameters.AddWithValue("@firstname", request.FirstName);
                command.Parameters.AddWithValue("@lastname", request.LastName);

                command.ExecuteNonQuery();
            }

            return Ok();
        }
    }

    public class RegisterUserRequest
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsDodUser { get; set; } // bool is a value type, so it's non-nullable by default
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

}
