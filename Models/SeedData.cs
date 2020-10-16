using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using stunning_robot_HR.Data;
using System;
using System.Linq; 

namespace stunning_robot_HR.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new stunning_robot_HRContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<stunning_robot_HRContext>>()))
            {
                
                if (context.Staff.Any())
                {
                    return;  
                }

                context.Staff.AddRange(
                    new Staff
                    {
                        LastName = "Ruiz",
                        TotalHoursWorked = 200,
                        NumberOfAvailableDaysOff = 11,
                        
                    },

                    new Staff
                    {
                        LastName = "Jordan",
                        TotalHoursWorked = 120,
                        NumberOfAvailableDaysOff = 8,
                    },

                    new Staff
                    {
                        LastName = "Pippen",
                        TotalHoursWorked = 250,
                        NumberOfAvailableDaysOff = 15,
                    },

                    new Staff
                    {
                        LastName = "Starks",
                        TotalHoursWorked = 300,
                        NumberOfAvailableDaysOff = 20,
                    }
                );
                context.SaveChanges();
            }
        }
    }
} 