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
                name: "DayOffRequest",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RequestId = table.Column<int>(nullable: false),
                    StartDayOfTimeRequest = table.Column<DateTime>(nullable: false),
                    EndDayOfTimeOffRequest = table.Column<DateTime>(nullable: false),
                    TotalNumberOfAvailableDaysOff = table.Column<double>(nullable: false),
                    StaffId1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOffRequest", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_DayOffRequest_Staff_StaffId1",
                        column: x => x.StaffId1,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayOffRequest_StaffId1",
                table: "DayOffRequest",
                column: "StaffId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayOffRequest");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
