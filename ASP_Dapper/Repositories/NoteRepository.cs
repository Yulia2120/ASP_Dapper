using ASP_Dapper.Models;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;

namespace ASP_Dapper.Repositories
{
    public class NoteRepository
    {
        private static readonly string _db = @"Data Source=SQL8001.site4now.net;Initial Catalog=db_a8e19a_mydata2;User Id=db_a8e19a_mydata2_admin;Password=mydata22";


        public static async Task<List<Note>> GetNotes()
        {
            using (IDbConnection connect = new SqlConnection(_db))
            {
                return (List<Note>)await connect.GetAllAsync<Note>();
            }

        }

    }
}
