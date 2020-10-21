using System.ComponentModel.DataAnnotations;

namespace stunning_robot_HR.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Total Hours Worked")]
        public int TotalHoursWorked { get; set; }
        
        [Display(Name = "Total Num Of Available Days Off")]
        public int NumberOfAvailableDaysOff { get; set; }
    }
}