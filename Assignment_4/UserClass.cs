namespace CreateUser_API.Controllers
{
    public class User
    {
        public int UserId { get; set; } // No constructor parameter for UserId since it's likely set by the database.
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool IsDoDUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string username, string passwordHash, string email, bool isDoDUser, string firstName, string lastName)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            IsDoDUser = isDoDUser;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
    }
}
