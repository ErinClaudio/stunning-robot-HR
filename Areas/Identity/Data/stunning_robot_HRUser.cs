using System;
using Microsoft.AspNetCore.Identity;

namespace stunning_robot_HR.Areas.Identity.Data
{
    public class stunning_robot_HRUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}