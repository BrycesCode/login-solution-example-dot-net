using System.ComponentModel.DataAnnotations;

namespace LoginSolution.Models
{
    public class UserInfoModel
    {
        [Key]
        public string Id { get; set; }  
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
