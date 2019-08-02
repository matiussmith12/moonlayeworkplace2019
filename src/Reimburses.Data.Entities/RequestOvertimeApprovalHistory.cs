using Data.Entities;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reimburses.Data.Entities
{
    public class RequestOvertimeApprovalHistory : Entity
    {

        public int EmployeeId { get; set; }

        public DateTimeOffset ApprovalDate { get; set; }
        public ApprovalStatusRequestOvertime ApprovalStatusRequestOvertime { get; set; }

        public int RequestOvertimeId { get; set; }
        public virtual RequestOvertime RequestOvertime { get; set; }
    }
}
