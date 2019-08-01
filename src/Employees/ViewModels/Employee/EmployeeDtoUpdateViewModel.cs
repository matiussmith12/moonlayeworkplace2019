using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.Employee
{
    public class EmployeeDtoUpdateViewModel
    {
        public EmployeeDtoUpdateViewModel()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CurrentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public string PersonalEmail { get; set; }

        public IFormFile Image { get; set; }

        internal Data.Entities.Employee ToEntity(Data.Entities.Employee entity)
        {
            entity.FirstName = this.FirstName;
            entity.LastName = this.LastName;
            entity.FullName = this.FirstName + " " + this.LastName;
            entity.OfficeEmail = this.FirstName.ToLower() + "." + this.LastName.ToLower() + "@moonlay.com";
            entity.CurrentAddress = this.CurrentAddress;
            entity.PhoneNumber = this.PhoneNumber;
            entity.TelephoneNumber = this.TelephoneNumber;
            entity.EmergencyContactName = this.EmergencyContactName;
            entity.EmergencyContactNumber = this.EmergencyContactNumber;
            entity.EmergencyContactRelationship = this.EmergencyContactRelationship;
            entity.PersonalEmail = this.PersonalEmail;

            return entity;
        }

    }
}
