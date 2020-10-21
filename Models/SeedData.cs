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
                        
                        FirstName = "Tony",
                        LastName = "Ruiz",
                        TotalHoursWorked = 200,
                        NumberOfAvailableDaysOff = 11,
                        
                    },

                    new Staff
                    {
                        
                        FirstName = "Micheal",
                        LastName = "Jordan",
                        TotalHoursWorked = 120,
                        NumberOfAvailableDaysOff = 8,
                    },

                    new Staff
                    {
                        FirstName = "Scottie",
                        LastName = "Pippen",
                        TotalHoursWorked = 250,
                        NumberOfAvailableDaysOff = 15,
                    },

                    new Staff
                    {
                        FirstName = "John",
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