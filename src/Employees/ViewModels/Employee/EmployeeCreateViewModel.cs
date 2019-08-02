using System;
using System.ComponentModel.DataAnnotations;
using Employees.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Employees.ViewModels.Employee
{
    public class EmployeeCreateViewModel
    {
        [Display(Name = "First Name")]
        [Required()]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


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
        public string PersonalEmail { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public int IdentityCardNumber { get; set; }

        //WorkerData
        public EmployeeStatus StatusWorker { get; set; }
        public string LineManager { get; set; }
        public int Grading { get; set; }
        public string SpecialNotes { get; set; }
        public decimal Salary { get; set; }
        public string NoSurat { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public DateTimeOffset PassProbation { get; set; }
        public DateTimeOffset TransferDate { get; set; }


        //NPWP
        public string NPWP { get; set; }
        public string NPWPAddress { get; set; }

        //Employee to Role
        public int EmployeeRoleId { get; set; }
        public int BankAccountId { get; set; }
        public int DepartmentId { get; set; }
        public int EducationId { get; set; }
        public int GradingTitleId { get; set; }
        public int ReligionId { get; set; }
        public int WorkPlacementId { get; set; }



        internal Data.Entities.Employee ToEntity()
        {
            return new Data.Entities.Employee
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                InitialName = this.FirstName.Substring(0, 3).ToLower(),
                Username = this.Username,
                Password = this.Password,
                FullName = this.FirstName +" "  +this.LastName,
                KTPAddress = this.KTPAddress,
                CurrentAddress = this.CurrentAddress,
                Gender = this.Gender,
                MaritalStatus = this.MaritalStatus,
                PhoneNumber = this.PhoneNumber,
                TelephoneNumber = this.TelephoneNumber,
                EmergencyContactName = this.EmergencyContactName,
                EmergencyContactNumber = this.EmergencyContactNumber,
                EmergencyContactRelationship = this.EmergencyContactRelationship,
                BirthLocation = this.BirthLocation,
                PersonalEmail = this.PersonalEmail,
                OfficeEmail = this.FirstName.ToLower() + "." +this.LastName.ToLower() + "@moonlay.com",
                BirthDate = this.BirthDate,
                IdentityCardNumber = this.IdentityCardNumber,
                StatusWorker = this.StatusWorker,
                LineManager = this.LineManager,
                Grading = this.Grading,
                SpecialNotes = this.SpecialNotes,
                Salary = this.Salary,
                NoSurat = this.NoSurat,
                JoinDate = this.JoinDate,
                PassProbation = this.PassProbation,
                TransferDate = this.TransferDate,
                NPWPAddress = this.NPWPAddress,
                CashOutLeave = 0,
                DebtHour = 0,
                MedicalPlafon = this.Salary / 2,
                LeaveTotal = 12,
                RemainingLeave = 12,
                SickLeaveTotal = 1,
                RemainingSickLeave = 1,
                ComplimentLeaveTotal = 0,
                RemainingComplimentLeave = 0,
                EmployeeRoleId = this.EmployeeRoleId,
                BankAccountId = this.BankAccountId,
                DepartmentId = this.DepartmentId,
                EducationId = this.EducationId,
                GradingTitleId = this.GradingTitleId,
                ReligionId = this.ReligionId,
                WorkPlacementId = this.WorkPlacementId
            };
        }
    }
}
