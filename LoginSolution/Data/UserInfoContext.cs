using LoginSolution.Models;
using System.Data.Entity;

namespace LoginSolution.Data
{
    public class UserInfoContext : DbContext
    {

        public DbSet<UserInfoModel> UserInfo { get; set; }
    }
}
