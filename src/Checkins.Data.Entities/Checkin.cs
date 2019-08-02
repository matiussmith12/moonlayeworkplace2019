using Data.Entities;
using Employees.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.Data.Entities
{
    public class Checkin : Entity
    {
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public bool IsLate { get; set; }
        

        //Checkin to Employee
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public void VerifyLate(string lateTime)
        {
            var now = DateTime.Now;
            var datestring = now.ToString("yyyy-MM-dd");
            DateTimeOffset.TryParse(datestring + "T"+lateTime, out var late);
            this.IsLate = now > late.ToLocalTime();
        }

    }
}
