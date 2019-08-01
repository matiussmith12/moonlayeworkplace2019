using Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;

namespace Employees.Data.Entities
{
    public class Employee : Entity, ISoftDelete
    {
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string InitialName { get; set; }

        //Personal Data 
        public string KTPAddress { get; set; }
        public string CurrentAddress { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public string BirthLocation { get; set; }
        public string LastEducation { get; set; }
        public string PersonalEmail { get; set; }
        public string OfficeEmail { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public int IdentityCardNumber { get; set; }

        //WorkerData
        public EmployeeStatus StatusWorker { get; set; }
        public string LineManager { get; set; }
        public int Grading { get; set; }
        public string ReasonLeaving { get; set; }
        public string SpecialNotes { get; set; }
        public decimal Salary { get; set; }
        public string NoSurat { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public DateTimeOffset PassProbation { get; set; }
        public DateTimeOffset TransferDate { get; set; }
        public DateTimeOffset ResignationDate { get; set; }
        public decimal CashOutLeave { get; set; }

        //NPWP
        public string NPWP { get; set; }
        public string NPWPAddress { get; set; }


        // Leave Data
        public int DebtHour { get; set; }
        public decimal MedicalPlafon { get; set; }
        public int LeaveTotal { get; set; }
        public int RemainingLeave { get; set; }
        public int ComplimentLeaveTotal { get; set; }
        public int RemainingComplimentLeave { get; set; }
        public int SickLeaveTotal { get; set; }
        public int RemainingSickLeave { get; set; }

        //Image Profile
        public string ImageUrl { get; set; }


        //Employee to Role
        public int EmployeeRoleId { get; set; }
        public int BankAccountId { get; set; }
        public int DepartmentId { get; set; }
        public int EducationId { get; set; }
        public int GradingTitleId { get; set; }
        public int ReligionId { get; set; }
        public int WorkPlacementId { get; set; }

        public EmployeeRole EmployeeRole { get; set; }
        public BankAccount BankAccount { get; set; }
        public Department Department { get; set; }
        public Education Education { get; set; }
        public GradingTitle GradingPosition { get; set; }
        public Religion Faith { get; set; }
        public WorkPlacement WorkPlacement { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTimeOffset? Deleted { get; set; }

        public string DeleteBy { get; set; }
    }

    public enum MaritalStatus
    {
        single = 1,
        Married
    }

    public enum Gender
    {
        Male = 1,
        Female
    }

    public enum EmployeeStatus
    {
        Permanent = 1,
        Contract
    }
}
