namespace ASP_Dapper.Models
{
    public class CryptPass
    {
        public string Generate(string pass)
        {
            return BCrypt.Net.BCrypt.HashPassword(pass);
        }
    }
}
