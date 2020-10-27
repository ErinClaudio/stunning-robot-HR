using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace stunning_robot_HR.Migrations
{
    public partial class DayOffRequestCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Staff",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "StaffId");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Staff",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "Id");
        }
    }
}
