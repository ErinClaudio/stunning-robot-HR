using Microsoft.AspNetCore.Identity;

namespace stunning_robot_HR.Areas.Identity.Data
{
    public class AdminUser : IdentityUser
    {
        [PersonalData]
        public override string Email { get; set; }
        
        [PersonalData]
        public string Password { get; set; }
        
        [PersonalData]
        public string ConfirmPassword { get; set; }
        
    }
}