using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace stunning_robot_HR.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "DayOffRequests",
                columns: table => new
                {
                    RequestId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDayOfTimeRequest = table.Column<DateTime>(nullable: false),
                    EndDayOfTimeOffRequest = table.Column<DateTime>(nullable: false),
                    TotalNumberOfAvailableDaysOff = table.Column<double>(nullable: false),
                    StaffId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOffRequests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_DayOffRequests_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayOffRequests_StaffId",
                table: "DayOffRequests",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayOffRequests");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
