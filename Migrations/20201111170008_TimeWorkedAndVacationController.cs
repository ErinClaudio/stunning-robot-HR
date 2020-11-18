using Microsoft.EntityFrameworkCore.Migrations;

namespace stunning_robot_HR.Migrations
{
    public partial class TimeWorkedAndVacationController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeWorkedAndVacation",
                columns: table => new
                {
                    TimeWorkedAndVacationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalNumberOfDaysWorked = table.Column<int>(nullable: false),
                    TotalNumberOfAvailableVacationDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeWorkedAndVacation", x => x.TimeWorkedAndVacationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeWorkedAndVacation");
        }
    }
}
