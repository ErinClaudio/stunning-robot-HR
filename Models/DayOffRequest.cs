using System;
using System.ComponentModel.DataAnnotations;

namespace stunning_robot_HR.Models
{
    public class DayOffRequest
    {
        [Key]
        public int RequestId { get; set; }
        
        //this is the length of time requested off
        
        [Display(Name = "Start of Day off request")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}" , ApplyFormatInEditMode = true)]
        public DateTime StartDayOfTimeRequest { get; set; }
        
        [Display(Name = "Start of Day off request")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}" , ApplyFormatInEditMode = true)]
        public DateTime EndDayOfTimeOffRequest { get; set; }
        
        public double TotalNumberOfAvailableDaysOff { get; set; }

        public virtual Staff Staff { get; set; }
    }
}