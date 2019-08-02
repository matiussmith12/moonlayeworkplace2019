using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class Alter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuickLeaveApprovalHistory_QuickLeaves_QuickLeaveId",
                table: "QuickLeaveApprovalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_QuickLeaves_Departments_departmentId",
                table: "QuickLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_QuickLeaves_Groups_groupId",
                table: "QuickLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestBusinesstripApprovalHistory_RequestBusinesstrips_RequestBusinesstripId",
                table: "RequestBusinesstripApprovalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestMedicalApprovalHistory_RequestMedicals_RequestMedicalId",
                table: "RequestMedicalApprovalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestOvertimeApprovalHistory_Employees_EmployeeId",
                table: "RequestOvertimeApprovalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestOvertimeApprovalHistory_RequestOvertimes_RequestOvertimeId",
                table: "RequestOvertimeApprovalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestOvertimes_Departments_departmentId",
                table: "RequestOvertimes");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestOvertimes_Groups_groupId",
                table: "RequestOvertimes");

            migrationBuilder.DropIndex(
                name: "IX_RequestOvertimes_departmentId",
                table: "RequestOvertimes");

            migrationBuilder.DropIndex(
                name: "IX_RequestOvertimes_groupId",
                table: "RequestOvertimes");

            migrationBuilder.DropIndex(
                name: "IX_RequestOvertimeApprovalHistory_EmployeeId",
                table: "RequestOvertimeApprovalHistory");

            migrationBuilder.DropIndex(
                name: "IX_QuickLeaves_departmentId",
                table: "QuickLeaves");

            migrationBuilder.DropIndex(
                name: "IX_QuickLeaves_groupId",
                table: "QuickLeaves");

            migrationBuilder.RenameColumn(
                name: "transportReimbursement",
                table: "RequestOvertimes",
                newName: "TransportReimbursement");

            migrationBuilder.RenameColumn(
                name: "totalOvertime",
                table: "RequestOvertimes",
                newName: "TotalOvertime");

            migrationBuilder.RenameColumn(
                name: "startTime",
                table: "RequestOvertimes",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "requestTo",
                table: "RequestOvertimes",
                newName: "RequestTo");

            migrationBuilder.RenameColumn(
                name: "projectName",
                table: "RequestOvertimes",
                newName: "ProjectName");

            migrationBuilder.RenameColumn(
                name: "overtimeType",
                table: "RequestOvertimes",
                newName: "OvertimeType");

            migrationBuilder.RenameColumn(
                name: "mealReimbursement",
                table: "RequestOvertimes",
                newName: "MealReimbursement");

            migrationBuilder.RenameColumn(
                name: "groupId",
                table: "RequestOvertimes",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "finishTime",
                table: "RequestOvertimes",
                newName: "FinishTime");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "RequestOvertimes",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "dateOvertime",
                table: "RequestOvertimes",
                newName: "DateOvertime");

            migrationBuilder.RenameColumn(
                name: "totalCostReimburse",
                table: "RequestMedicals",
                newName: "TotalCostReimburse");

            migrationBuilder.RenameColumn(
                name: "totalCostNominal",
                table: "RequestMedicals",
                newName: "TotalCostNominal");

            migrationBuilder.RenameColumn(
                name: "medicationType",
                table: "RequestMedicals",
                newName: "MedicationType");

            migrationBuilder.RenameColumn(
                name: "dateRequestMedical",
                table: "RequestMedicals",
                newName: "DateRequestMedical");

            migrationBuilder.RenameColumn(
                name: "totalCostReimburse",
                table: "RequestBusinesstrips",
                newName: "TotalCostReimburse");

            migrationBuilder.RenameColumn(
                name: "totalCostNominal",
                table: "RequestBusinesstrips",
                newName: "TotalCostNominal");

            migrationBuilder.RenameColumn(
                name: "to",
                table: "RequestBusinesstrips",
                newName: "To");

            migrationBuilder.RenameColumn(
                name: "from",
                table: "RequestBusinesstrips",
                newName: "From");

            migrationBuilder.RenameColumn(
                name: "dateBusinessTrip",
                table: "RequestBusinesstrips",
                newName: "DateBusinessTrip");

            migrationBuilder.RenameColumn(
                name: "RequestBusinesstripId",
                table: "RequestBusinesstripApprovalHistory",
                newName: "RequestBusinessTripId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestBusinesstripApprovalHistory_RequestBusinesstripId",
                table: "RequestBusinesstripApprovalHistory",
                newName: "IX_RequestBusinesstripApprovalHistory_RequestBusinessTripId");

            migrationBuilder.RenameColumn(
                name: "totalOvertime",
                table: "QuickLeaves",
                newName: "TotalOvertime");

            migrationBuilder.RenameColumn(
                name: "startTime",
                table: "QuickLeaves",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "requestTo",
                table: "QuickLeaves",
                newName: "RequestTo");

            migrationBuilder.RenameColumn(
                name: "purpose",
                table: "QuickLeaves",
                newName: "Purpose");

            migrationBuilder.RenameColumn(
                name: "projectName",
                table: "QuickLeaves",
                newName: "ProjectName");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "QuickLeaves",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "groupId",
                table: "QuickLeaves",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "finishTime",
                table: "QuickLeaves",
                newName: "FinishTime");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "QuickLeaves",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "QuickLeaves",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "EmployeId",
                table: "QuickLeaves",
                newName: "EmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "RequestTo",
                table: "RequestOvertimes",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "RequestOvertimes",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "RequestOvertimes",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Deleted",
                table: "RequestOvertimes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "RequestOvertimes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "RequestOvertimes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "RequestOvertimeId",
                table: "RequestOvertimeApprovalHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCostReimburse",
                table: "RequestMedicals",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "TotalCostNominal",
                table: "RequestMedicals",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "RequestMedicals",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Deleted",
                table: "RequestMedicals",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "RequestMedicals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "RequestMedicalId",
                table: "RequestMedicalApprovalHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCostReimburse",
                table: "RequestBusinesstrips",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "TotalCostNominal",
                table: "RequestBusinesstrips",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "To",
                table: "RequestBusinesstrips",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "From",
                table: "RequestBusinesstrips",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "RequestBusinesstrips",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Deleted",
                table: "RequestBusinesstrips",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "RequestBusinesstrips",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "RequestBusinessTripId",
                table: "RequestBusinesstripApprovalHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "QuickLeaves",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "QuickLeaves",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AddColumn<string>(
                name: "DeleteBy",
                table: "QuickLeaves",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Deleted",
                table: "QuickLeaves",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "QuickLeaves",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "QuickLeaveId",
                table: "QuickLeaveApprovalHistory",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Checkins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_QuickLeaveApprovalHistory_QuickLeaves_QuickLeaveId",
                table: "QuickLeaveApprovalHistory",
                column: "QuickLeaveId",
                principalTable: "QuickLeaves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestBusinesstripApprovalHistory_RequestBusinesstrips_RequestBusinessTripId",
                table: "RequestBusinesstripApprovalHistory",
                column: "RequestBusinessTripId",
                principalTable: "RequestBusinesstrips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestMedicalApprovalHistory_RequestMedicals_RequestMedicalId",
                table: "RequestMedicalApprovalHistory",
                column: "RequestMedicalId",
                principalTable: "RequestMedicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOvertimeApprovalHistory_RequestOvertimes_RequestOvertimeId",
                table: "RequestOvertimeApprovalHistory",
                column: "RequestOvertimeId",
                principalTable: "RequestOvertimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuickLeaveApprovalHistory_QuickLeaves_QuickLeaveId",
                table: "QuickLeaveApprovalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestBusinesstripApprovalHistory_RequestBusinesstrips_RequestBusinessTripId",
                table: "RequestBusinesstripApprovalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestMedicalApprovalHistory_RequestMedicals_RequestMedicalId",
                table: "RequestMedicalApprovalHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestOvertimeApprovalHistory_RequestOvertimes_RequestOvertimeId",
                table: "RequestOvertimeApprovalHistory");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "RequestOvertimes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "RequestOvertimes");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "RequestOvertimes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "RequestOvertimes");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "RequestMedicals");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "RequestMedicals");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "RequestMedicals");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "RequestBusinesstrips");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "RequestBusinesstrips");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "RequestBusinesstrips");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "QuickLeaves");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "QuickLeaves");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "QuickLeaves");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Checkins");

            migrationBuilder.RenameColumn(
                name: "TransportReimbursement",
                table: "RequestOvertimes",
                newName: "transportReimbursement");

            migrationBuilder.RenameColumn(
                name: "TotalOvertime",
                table: "RequestOvertimes",
                newName: "totalOvertime");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "RequestOvertimes",
                newName: "startTime");

            migrationBuilder.RenameColumn(
                name: "RequestTo",
                table: "RequestOvertimes",
                newName: "requestTo");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "RequestOvertimes",
                newName: "projectName");

            migrationBuilder.RenameColumn(
                name: "OvertimeType",
                table: "RequestOvertimes",
                newName: "overtimeType");

            migrationBuilder.RenameColumn(
                name: "MealReimbursement",
                table: "RequestOvertimes",
                newName: "mealReimbursement");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "RequestOvertimes",
                newName: "groupId");

            migrationBuilder.RenameColumn(
                name: "FinishTime",
                table: "RequestOvertimes",
                newName: "finishTime");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "RequestOvertimes",
                newName: "departmentId");

            migrationBuilder.RenameColumn(
                name: "DateOvertime",
                table: "RequestOvertimes",
                newName: "dateOvertime");

            migrationBuilder.RenameColumn(
                name: "TotalCostReimburse",
                table: "RequestMedicals",
                newName: "totalCostReimburse");

            migrationBuilder.RenameColumn(
                name: "TotalCostNominal",
                table: "RequestMedicals",
                newName: "totalCostNominal");

            migrationBuilder.RenameColumn(
                name: "MedicationType",
                table: "RequestMedicals",
                newName: "medicationType");

            migrationBuilder.RenameColumn(
                name: "DateRequestMedical",
                table: "RequestMedicals",
                newName: "dateRequestMedical");

            migrationBuilder.RenameColumn(
                name: "TotalCostReimburse",
                table: "RequestBusinesstrips",
                newName: "totalCostReimburse");

            migrationBuilder.RenameColumn(
                name: "TotalCostNominal",
                table: "RequestBusinesstrips",
                newName: "totalCostNominal");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "RequestBusinesstrips",
                newName: "to");

            migrationBuilder.RenameColumn(
                name: "From",
                table: "RequestBusinesstrips",
                newName: "from");

            migrationBuilder.RenameColumn(
                name: "DateBusinessTrip",
                table: "RequestBusinesstrips",
                newName: "dateBusinessTrip");

            migrationBuilder.RenameColumn(
                name: "RequestBusinessTripId",
                table: "RequestBusinesstripApprovalHistory",
                newName: "RequestBusinesstripId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestBusinesstripApprovalHistory_RequestBusinessTripId",
                table: "RequestBusinesstripApprovalHistory",
                newName: "IX_RequestBusinesstripApprovalHistory_RequestBusinesstripId");

            migrationBuilder.RenameColumn(
                name: "TotalOvertime",
                table: "QuickLeaves",
                newName: "totalOvertime");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "QuickLeaves",
                newName: "startTime");

            migrationBuilder.RenameColumn(
                name: "RequestTo",
                table: "QuickLeaves",
                newName: "requestTo");

            migrationBuilder.RenameColumn(
                name: "Purpose",
                table: "QuickLeaves",
                newName: "purpose");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "QuickLeaves",
                newName: "projectName");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "QuickLeaves",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "QuickLeaves",
                newName: "groupId");

            migrationBuilder.RenameColumn(
                name: "FinishTime",
                table: "QuickLeaves",
                newName: "finishTime");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "QuickLeaves",
                newName: "departmentId");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "QuickLeaves",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "QuickLeaves",
                newName: "EmployeId");

            migrationBuilder.AlterColumn<string>(
                name: "requestTo",
                table: "RequestOvertimes",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "projectName",
                table: "RequestOvertimes",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<int>(
                name: "RequestOvertimeId",
                table: "RequestOvertimeApprovalHistory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "totalCostReimburse",
                table: "RequestMedicals",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "totalCostNominal",
                table: "RequestMedicals",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "RequestMedicalId",
                table: "RequestMedicalApprovalHistory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "totalCostReimburse",
                table: "RequestBusinesstrips",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "totalCostNominal",
                table: "RequestBusinesstrips",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "to",
                table: "RequestBusinesstrips",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "from",
                table: "RequestBusinesstrips",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<int>(
                name: "RequestBusinesstripId",
                table: "RequestBusinesstripApprovalHistory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "projectName",
                table: "QuickLeaves",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "note",
                table: "QuickLeaves",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<int>(
                name: "QuickLeaveId",
                table: "QuickLeaveApprovalHistory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_RequestOvertimes_departmentId",
                table: "RequestOvertimes",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestOvertimes_groupId",
                table: "RequestOvertimes",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestOvertimeApprovalHistory_EmployeeId",
                table: "RequestOvertimeApprovalHistory",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_QuickLeaves_departmentId",
                table: "QuickLeaves",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_QuickLeaves_groupId",
                table: "QuickLeaves",
                column: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuickLeaveApprovalHistory_QuickLeaves_QuickLeaveId",
                table: "QuickLeaveApprovalHistory",
                column: "QuickLeaveId",
                principalTable: "QuickLeaves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuickLeaves_Departments_departmentId",
                table: "QuickLeaves",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuickLeaves_Groups_groupId",
                table: "QuickLeaves",
                column: "groupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestBusinesstripApprovalHistory_RequestBusinesstrips_RequestBusinesstripId",
                table: "RequestBusinesstripApprovalHistory",
                column: "RequestBusinesstripId",
                principalTable: "RequestBusinesstrips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestMedicalApprovalHistory_RequestMedicals_RequestMedicalId",
                table: "RequestMedicalApprovalHistory",
                column: "RequestMedicalId",
                principalTable: "RequestMedicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOvertimeApprovalHistory_Employees_EmployeeId",
                table: "RequestOvertimeApprovalHistory",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOvertimeApprovalHistory_RequestOvertimes_RequestOvertimeId",
                table: "RequestOvertimeApprovalHistory",
                column: "RequestOvertimeId",
                principalTable: "RequestOvertimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOvertimes_Departments_departmentId",
                table: "RequestOvertimes",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestOvertimes_Groups_groupId",
                table: "RequestOvertimes",
                column: "groupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
