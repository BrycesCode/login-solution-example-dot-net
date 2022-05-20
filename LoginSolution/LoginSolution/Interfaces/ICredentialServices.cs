using LoginSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginSolution.Interfaces
{
    public interface ICredentialServices
    {
        public Task<IEnumerable<UserInfoModel>> GetUserInfo(string email);

        public Task<ActionResult<string>> InsertUser(UserInfoModel dbModel);

    }
}
