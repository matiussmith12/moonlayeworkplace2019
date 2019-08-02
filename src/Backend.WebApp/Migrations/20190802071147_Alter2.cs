using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class Alter2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "QuickLeaves");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "QuickLeaves");

            migrationBuilder.CreateIndex(
                name: "IX_QuickLeaves_EmployeeId",
                table: "QuickLeaves",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuickLeaves_Employees_EmployeeId",
                table: "QuickLeaves",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuickLeaves_Employees_EmployeeId",
                table: "QuickLeaves");

            migrationBuilder.DropIndex(
                name: "IX_QuickLeaves_EmployeeId",
                table: "QuickLeaves");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "QuickLeaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "QuickLeaves",
                nullable: false,
                defaultValue: 0);
        }
    }
}
