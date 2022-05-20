using LoginSolution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Data.SqlClient;
using Dapper;
using Isopoh.Cryptography.Argon2;

namespace LoginSolution.Interfaces
{
    public class CredentialServices : ICredentialServices
    {
        private readonly IOptions<DatabaseOptions> _dbOptions;

        public CredentialServices(IOptions<DatabaseOptions> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public async Task<IEnumerable<UserInfoModel>> GetUserInfo(string email)
        {
            
            var queryString = $"SELECT * FROM UserData WHERE email= '{email}'";
            using var connection = new SqlConnection(_dbOptions.Value.Database);
            try
            {

                IEnumerable<UserInfoModel> response = await connection.QueryAsync<UserInfoModel>(queryString);
                return response;

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<ActionResult<string>> InsertUser(UserInfoModel dbModel)
        {
            var hashed = Argon2.Hash(dbModel.password) ;


            var queryString = $"INSERT INTO UserData (email, username, password) VALUES ('{dbModel.Email}', '{dbModel.userName}','{hashed}')";
            try
            {
                using var connection = new SqlConnection(_dbOptions.Value.Database);
                var response = await connection.QueryAsync<UserInfoModel>(queryString);
                return "ok";

            }
            catch(Exception ex)
            {
                throw;
            }
        }

    }
}
