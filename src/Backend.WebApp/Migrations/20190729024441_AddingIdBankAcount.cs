using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class AddingIdBankAcount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankAccountId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GradingTitleId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReligionId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkPlacementId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BankAccountId",
                table: "Employees",
                column: "BankAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_BankAccounts_BankAccountId",
                table: "Employees",
                column: "BankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_BankAccounts_BankAccountId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_BankAccountId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BankAccountId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "GradingTitleId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReligionId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkPlacementId",
                table: "Employees");
        }
    }
}
