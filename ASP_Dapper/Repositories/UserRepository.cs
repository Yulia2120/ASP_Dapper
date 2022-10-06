using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;

namespace ASP_Dapper.Repositories
{
    public static class UserRepository
    {
        private static readonly string _db = "Server=(localdb)\\MSSQLLocalDB;Database=Notes;Trusted_Connection=True;";
        public static async Task<List<User>> GetUsers()
        {
            using (IDbConnection connect = new SqlConnection(_db))
            {
                return (List<User>)await connect.GetAllAsync<User>();
            }

        }
        public static async Task<User> Get(int id)
        {
            using (IDbConnection connect = new SqlConnection(_db))
            {
               return await connect.GetAsync<User>(id);
            }
        }



    }
}
