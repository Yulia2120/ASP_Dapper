using Microsoft.AspNetCore.Mvc;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using ASP_Dapper.Repositories;

namespace ASP_Dapper.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return await UserRepository.GetUsers();
           

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            User user = await UserRepository.Get(id);
            return Ok(user);

        }
       

     
       
        // [HttpPut("Put")]
        //public void PutUser(User users)
        //{
        //    using (IDbConnection db = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Products;Trusted_Connection=True;"))
        //    {
        //        db.Insert(users);
        //    }

        //}
        //[HttpDelete("Delete")]
        //public void DeleteUser(int id)
        //{
        //    using (IDbConnection db = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Products;Trusted_Connection=True;"))
        //    {

        //        // db.Delete(id);
        //    }

        //}
    }
}


