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
                        
                        FullName = "Tony Ruiz",
                        //DateOfBirth =,
                        Position = "Automotive Tech",
                        //StartDate =,
                        
                    },

                    new Staff
                    {
                        
                        FullName = "Micheal Jordan",
                        //DateOfBirth =,
                        Position = "Pharmacy Tech",
                        //StartDate =,

                    },

                    new Staff
                    {
                        FullName = "Scottie Pippen",
                        //DateOfBirth =,
                        Position = "Bakery Clerk",
                        //StartDate =,
                    },

                    new Staff
                    {
                        FullName = "John Starks",
                        //DateOfBirth =,
                        Position = "Optometry Sales",
                        //StartDate =,
                    }
                );
                context.SaveChanges();
            }
        }
    }
} 