using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Data
{
    public class stunning_robot_HRContext : DbContext
    {
        public stunning_robot_HRContext(DbContextOptions<stunning_robot_HRContext> options)
            : base(options)
        {
        }
        
        public DbSet<Staff> Staff { get; set; } 
        public DbSet<DayOffRequest> DayOffRequests { get; set; }
        public DbSet<TimeWorkedAndVacation> TimeWorkedAndVacation { get; set; }
    }
}