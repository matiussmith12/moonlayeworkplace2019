using System;
using Employees.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Employees.ViewModels.Employee
{
    public class EmployeeDto
    {
        public EmployeeDto()
        {

        }

        public EmployeeDto(Data.Entities.Employee employee)
        {
            ImageProfile = employee.ImageUrl;   
            Id = employee.Id;
            FullName = employee.FullName;
            Gender = employee.Gender;
            CurrentAddress = employee.CurrentAddress;
            PhoneNumber = employee.PhoneNumber;
            EmergencyContactName = employee.EmergencyContactName;
            EmergencyContactNumber = employee.EmergencyContactNumber;
            PersonalEmail = employee.PersonalEmail;
            InitialName = employee.InitialName;
            JoinDate = employee.JoinDate;
            OfficeEmail = employee.OfficeEmail;
            LineManager = employee.LineManager;
            StatusWorker = employee.StatusWorker;
            
        }

        public string ImageProfile { get; }
        public int Id { get; }
        public string FullName { get; }
        public Gender Gender { get; }
        public string CurrentAddress { get; }
        public string PhoneNumber { get; }
        public string EmergencyContactName { get; }
        public DateTime DateOfBirth { get; }
        public BankDto Bank { get; set; }
        public WorkPlacementDto WorkPlacement { get; set; }
        public DepartmentDto Department { get; set; }
        public PositionDto PositionTitle { get; set; }
        public string EmergencyContactNumber { get; }
        public string PersonalEmail { get; }
        public string InitialName { get; }
        public DateTimeOffset JoinDate { get; }
        public string OfficeEmail { get; }
        public string LineManager { get; }
        public EmployeeStatus StatusWorker { get; }
    }

    public class WorkPlacementDto
    {
        public WorkPlacementDto()
        {

        }
        public WorkPlacementDto(Data.Entities.WorkPlacement work)
        {
            WorkLocation = work.WorkLocation;
            OfficeAddress = work.OfficeAddress;
        }

        public string WorkLocation { get; }
        public string OfficeAddress { get; }
    }

    public class DepartmentDto
    {
        public DepartmentDto()
        {

        }

        public DepartmentDto(Data.Entities.Department department)
        {
            DepartmentName = department.DepartmentName;
        }

        public string DepartmentName { get; }
    }



    public class PositionDto
    {
        public PositionDto()
        {

        }

        public PositionDto(Data.Entities.EmployeeRole role)
        {
            PositionTitle = role.PositionTitle;
        }

        public string PositionTitle { get; }
    }

    public class BankDto
    {
        public BankDto()
        {

        }

        public BankDto(Data.Entities.BankAccount bank)
        {
            Id = bank.Id;
            BankName = bank.BankName;
            AccountNumber = bank.AccountNumber;
            BranchName = bank.BranchName;
            ReceiverName = bank.ReceiverName;
        }

        public int Id { get; }
        public string BankName { get; }
        public string AccountNumber { get; }
        public string BranchName { get; }
        public string ReceiverName { get; }
    }

    public class EmployeeUpdateDto 
    {
        public EmployeeUpdateDto()
        {

        }

    }

}