using System;
using System.ComponentModel.DataAnnotations;

namespace stunning_robot_HR.Models
{
    public class Staff
    {
        [Display(Name = "Full nfame")]
        public DateTime FullName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }

        [Display(Name = "Start Date")]
        public int StartDate { get; set; }
    }
}