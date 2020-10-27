using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using stunning_robot_HR.Models;

    public class DayOffRequestContext : DbContext
    {
        public DayOffRequestContext (DbContextOptions<DayOffRequestContext> options)
            : base(options)
        {
        }

        public DbSet<stunning_robot_HR.Models.DayOffRequest> DayOffRequest { get; set; }
    }
