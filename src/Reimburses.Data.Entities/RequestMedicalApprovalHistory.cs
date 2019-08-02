using Data.Entities;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reimburses.Data.Entities
{
    public class RequestMedicalApprovalHistory : Entity
    {

        public int EmployeeId { get; set; }

        public DateTimeOffset ApprovalDate { get; set; }
        public ApprovalStatusRequestMedical ApprovalStatusRequestMedical { get; set; }


        public int RequestMedicalId { get; set; }
        public virtual RequestMedical RequestMedical { get; set; }
    }
}
