using ASP_Dapper.Models;
using ASP_Dapper.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Dapper.Controllers
{
        [ApiController]
        [Route("[controller]")]
    public class AccountController : Controller
    {
       [HttpPost("Registr")]
        public  async Task<List<User>> Registr(User user)
        {
            return await UserRepository.RegistrUser(user.Username, user.Email, user.Password);
        }

    }
}
