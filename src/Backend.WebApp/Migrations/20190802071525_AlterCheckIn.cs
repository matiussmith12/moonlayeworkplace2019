using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class AlterCheckIn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Checkins_EmployeeId",
                table: "Checkins",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkins_Employees_EmployeeId",
                table: "Checkins",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkins_Employees_EmployeeId",
                table: "Checkins");

            migrationBuilder.DropIndex(
                name: "IX_Checkins_EmployeeId",
                table: "Checkins");
        }
    }
}
