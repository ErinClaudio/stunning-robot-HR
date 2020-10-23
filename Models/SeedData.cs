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
                        //StartDate =,
                        
                    },

                    new Staff
                    {
                        
                        FullName = "Micheal Jordan",
                        //DateOfBirth =,
                        //StartDate =,

                    },

                    new Staff
                    {
                        FullName = "Scottie Pippen",
                        //DateOfBirth =,
                        //StartDate =,
                    },

                    new Staff
                    {
                        FullName = "John Starks",
                        //DateOfBirth =,
                        //StartDate =,
                    }
                );
                context.SaveChanges();
            }
        }
    }
} 