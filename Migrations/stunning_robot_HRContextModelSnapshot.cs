﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using stunning_robot_HR.Data;

namespace stunning_robot_HR.Migrations
{
    [DbContext(typeof(stunning_robot_HRContext))]
    partial class stunning_robot_HRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("stunning_robot_HR.Models.DayOffRequest", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDayOfTimeOffRequest")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StaffId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDayOfTimeRequest")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalNumberOfAvailableDaysOff")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalNumberOfHoursWorked")
                        .HasColumnType("REAL");

                    b.HasKey("RequestId");

                    b.HasIndex("StaffId");

                    b.ToTable("DayOffRequests");
                });

            modelBuilder.Entity("stunning_robot_HR.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("StaffId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("stunning_robot_HR.Models.DayOffRequest", b =>
                {
                    b.HasOne("stunning_robot_HR.Models.Staff", "Staff")
                        .WithMany("DayOffRequests")
                        .HasForeignKey("StaffId");
                });
#pragma warning restore 612, 618
        }
    }
}
