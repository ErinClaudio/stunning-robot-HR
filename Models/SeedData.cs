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
                        DateOfBirth = 10,
                        Position = "Customer Service Rep",
                        StartDate = 3/12/2010,
                       
                        
                    },

                    new Staff
                    {
                        
                        FullName = "Micheal Jordan",
                        DateOfBirth = 1/15/1974,
                        Position = "Automotive Tech",
                        StartDate = 11/22/2000,
                        
                    },

                    new Staff
                    {
                        FullName = "Scottie Pippen",
                        DateOfBirth = 10/25/1954,
                        Position = "Sales Rep",
                        StartDate = 1/12/2015,
                    },

                    new Staff
                    {
                        FullName = "Jason Kidd",
                        DateOfBirth = 7/15/1944,
                        Position = "Custodian",
                        StartDate = 1/12/2015,
                    }
                );
                context.SaveChanges();
            }
        }
    }
} 