using System;
using Employees.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Employees.ViewModels.Employee
{
    public class EmployeeUpdateViewModel
    {
        public EmployeeUpdateViewModel() { }

        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
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
        public DateTime BirthDate { get; set; }
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
        public int LeaveTotal { get; set; }
        public int ComplimentLeaveTotal { get; set; }
        public int SickLeaveTotal { get; set; }

        //Image Profile
        

        internal Data.Entities.Employee ToEntity(Data.Entities.Employee entity)
        {
            entity.FirstName = this.FirstName;
            entity.LastName = this.LastName;
            entity.Username = this.Username;
            entity.Password = this.Password;
            entity.FullName = this.FirstName +" " + this.LastName;
            entity.InitialName = this.FirstName.Substring(0,3);
            entity.KTPAddress = this.KTPAddress;
            entity.CurrentAddress = this.CurrentAddress;
            entity.Gender = this.Gender;
            entity.MaritalStatus = this.MaritalStatus;
            entity.PhoneNumber = this.PhoneNumber;
            entity.TelephoneNumber = this.TelephoneNumber;
            entity.EmergencyContactName = this.EmergencyContactName;
            entity.EmergencyContactNumber = this.EmergencyContactNumber;
            entity.EmergencyContactRelationship = this.EmergencyContactRelationship;
            entity.BirthLocation = this.BirthLocation;
            entity.LastEducation = this.LastEducation;
            entity.PersonalEmail = this.PersonalEmail;
            entity.OfficeEmail = this.FirstName.ToLower() + "." + this.LastName.ToLower() + "@moonlay.com";
            entity.BirthDate = this.BirthDate;
            entity.IdentityCardNumber = this.IdentityCardNumber;
            entity.StatusWorker = this.StatusWorker;
            entity.LineManager = this.LineManager;
            entity.Grading = this.Grading;
            entity.ReasonLeaving = this.ReasonLeaving;
            entity.SpecialNotes = this.SpecialNotes;
            entity.Salary = this.Salary;
            entity.NoSurat = this.NoSurat;
            entity.JoinDate = this.JoinDate;
            entity.PassProbation = this.PassProbation;
            entity.TransferDate = this.TransferDate;
            entity.ResignationDate = this.ResignationDate;
            entity.CashOutLeave = this.CashOutLeave;
            entity.NPWP = this.NPWP;
            entity.NPWPAddress = this.NPWPAddress;
            entity.LeaveTotal = this.LeaveTotal;
            entity.SickLeaveTotal = this.SickLeaveTotal;
            entity.ComplimentLeaveTotal = this.ComplimentLeaveTotal;

            return entity;
        }
    }
}