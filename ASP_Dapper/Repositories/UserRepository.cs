using ASP_Dapper.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;

namespace ASP_Dapper.Repositories
{
    public class UserRepository
    {
        private static readonly string _db = @"Data Source=SQL8001.site4now.net;Initial Catalog=db_a8e19a_mydata2;User Id=db_a8e19a_mydata2_admin;Password=mydata22";
        public static async Task<List<User>> RegistrUser(string username, string email, string password)
        {
            using (IDbConnection connect = new SqlConnection(_db))
            {
                User regestration = new User() { Username = username, Email = email, Password = new CryptPass().Generate(password) };
                await connect.InsertAsync(regestration);
                return await SelectAllUsers(connect);
            }
            
        }

        public static async Task<List<User>> SelectAllUsers(IDbConnection connect)
        {
            return (List<User>)await connect.GetAllAsync<User>();
        }

        public static string TokenGenerate()
        {
            string defolt = "AB&CDE@FGHI&JKL?MNOPQRSTUVWXYZ#a$b%c*d1234567890";
            string token = "";
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = new Random().Next(1, 10);

                for (int j = 0; j < num; j++)
                {
                    token += defolt[new Random().Next(0, defolt.Length - 1)];
                }
            }
                return token;
        }
        //public static async Task<User> Authorize(string username, string password)
        //{
       //если юзер существует, то выдать токен Get Token
        //}
    }
}

////    wcf service contract
//[OperationContract]
//string Authorize(string username, string password);
//...

////service contract implementation
//string Authorize(string username, string password)
//{
//    if (!Validate(username, password)
//       throw new Exception("Invalid username or password");

//    var userId = GetUserId(username);

//    string token = Guid.New().ToString("N");
//    DataBase.AuthUsers.Add(new AuthUser(userId, token);

//    return token;
//}

//void SomeOperatin(string authToken)
//{
//    if (DataBase.AuthUsers.All(x => x.AuthToken != authToken)
//        throw new Exception("Access is denied");
//    ...
//}