using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Validate_User_Login_Request
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserLoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Get_configuration()
        {
            return _configuration;
        }

        [HttpPost("validate")]
        public IActionResult ValidateLogin([FromBody] ValidateUserLoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string? connectionString = _configuration.GetConnectionString("DefaultConnection");
            if (connectionString is null)
            {
                // Handle the case where the connection string is not found in the configuration
                return Problem("The connection string for 'DefaultConnection' was not found.");
            }

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("validateuserlogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", loginRequest.Username);
                    command.Parameters.AddWithValue("@passwordhash", loginRequest.PasswordHash);

                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Assuming result is the UserId
                        return Ok(new { UserId = result });
                    }
                    else
                    {
                        // User not found or invalid credentials
                        return Unauthorized(new { message = "Invalid credentials" });
                    }
                }
            }
        }

        public class ValidateUserLoginRequest
        {
            [Required]
            public string Username { get; set; } = string.Empty;

            [Required]
            public string PasswordHash { get; set; } = string.Empty;
        }
    }
}
