using System;
using System.ComponentModel.DataAnnotations;

namespace stunning_robot_HR.Models
{
    public class DayOffRequest
    {

        public int RequestId { get; set; }
        public int Id { get; set; }
        
        [Range(typeof(DateTime), "1/2/2004", "1/1/2020")]
        [Display(Name = "Day off request")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}" , ApplyFormatInEditMode = true)]
        public DateTime TimeOffRequest { get; set; }
        
        public int StaffId { get; set; }
        
        public virtual Staff Staff { get; set; }
    }
}