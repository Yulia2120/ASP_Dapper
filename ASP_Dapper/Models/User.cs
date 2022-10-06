using ASP_Dapper.Models;

namespace ASP_Dapper
{
    public class User : AuthenticateRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } 
        public  string Password { get; set; } 
        public string Token { get; set; } = string.Empty;

        //public User (User user, string token)
        //{
        //    Id = user.Id;
        //    UserName = user.UserName;
        //    Email = user.Email;
        //    Password = user.Password;
        //    Token = token;
        //}
    }
}
