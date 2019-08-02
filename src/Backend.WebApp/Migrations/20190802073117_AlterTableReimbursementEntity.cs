using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class AlterTableReimbursementEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RequestOvertimes_EmployeeId",
                table: "RequestOvertimes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestMedicals_EmployeeId",
                table: "RequestMedicals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestBusinesstrips_EmployeeId",
                table: "RequestBusinesstrips",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestBusinesstrips_Employees_EmployeeId",
                table: "RequestBusinesstrips",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestMedicals_Employees_EmployeeId",
                table: "RequestMedicals",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOvertimes_Employees_EmployeeId",
                table: "RequestOvertimes",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestBusinesstrips_Employees_EmployeeId",
                table: "RequestBusinesstrips");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestMedicals_Employees_EmployeeId",
                table: "RequestMedicals");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestOvertimes_Employees_EmployeeId",
                table: "RequestOvertimes");

            migrationBuilder.DropIndex(
                name: "IX_RequestOvertimes_EmployeeId",
                table: "RequestOvertimes");

            migrationBuilder.DropIndex(
                name: "IX_RequestMedicals_EmployeeId",
                table: "RequestMedicals");

            migrationBuilder.DropIndex(
                name: "IX_RequestBusinesstrips_EmployeeId",
                table: "RequestBusinesstrips");
        }
    }
}
