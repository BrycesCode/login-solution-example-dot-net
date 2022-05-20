using LoginSolution.Interfaces;
using LoginSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginSolution.Controllers
{
    public class UserController : Controller
    {
        private readonly ICredentialServices _credentialServices;

        public UserController(ICredentialServices credentialServices)
        {
            _credentialServices = credentialServices;
        }
        [HttpGet("/getUser")]

        public async Task<IEnumerable<UserInfoModel>> GetInfo(string email)
        {
            try
            {
                return await _credentialServices.GetUserInfo(email);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
