using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class AddingEntityRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EducationId",
                table: "Employees",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GradingTitleId",
                table: "Employees",
                column: "GradingTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReligionId",
                table: "Employees",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkPlacementId",
                table: "Employees",
                column: "WorkPlacementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Educations_EducationId",
                table: "Employees",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_GradingTitles_GradingTitleId",
                table: "Employees",
                column: "GradingTitleId",
                principalTable: "GradingTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Religions_ReligionId",
                table: "Employees",
                column: "ReligionId",
                principalTable: "Religions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Placements_WorkPlacementId",
                table: "Employees",
                column: "WorkPlacementId",
                principalTable: "Placements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Educations_EducationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_GradingTitles_GradingTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Religions_ReligionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Placements_WorkPlacementId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EducationId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_GradingTitleId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ReligionId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WorkPlacementId",
                table: "Employees");
        }
    }
}
