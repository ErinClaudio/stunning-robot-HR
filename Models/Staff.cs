using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace stunning_robot_HR.Models
{
    public class Staff
    {
        [Key]
        public int StaffId {get; set;}
        [Display(Name = "Full fame")]
        public string FullName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}" , ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}" , ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        
        public virtual ICollection<DayOffRequest> DayOffRequests { get; set; }
    }
}