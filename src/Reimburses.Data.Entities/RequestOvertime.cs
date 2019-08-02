using Data.Entities;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class RequestOvertime : Entity, ISoftDelete
    {
        public OvertimeType OvertimeType { get; set; }
        public DateTimeOffset DateOvertime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int TotalOvertime { get; set; }

        public string ProjectName { get; set; }
        public string RequestTo { get; set; }
        public int TransportReimbursement { get; set; }
        public int MealReimbursement { get; set; }        
        public string ImageUrl { get; set; }

        //Entity Relational
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int EmployeeId { get; set; }



        public bool IsDeleted { get; set; }
        public DateTimeOffset? Deleted { get; set; }
        public string DeleteBy { get; set; }

        public virtual ICollection<RequestOvertimeApprovalHistory> ApprovalHistory { get; set; }

        public bool HumanResourceDeptApproved(int hrStaffEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestOvertimeApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestOvertime = ApprovalStatusRequestOvertime.ApprovedByHR,
                RequestOvertime = this,
                EmployeeId = hrStaffEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });

            return true;
        }

        public bool HumanResourceDeptRejected(int hrStaffEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestOvertimeApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestOvertime = ApprovalStatusRequestOvertime.RejectedbyHR,
                RequestOvertime = this,
                EmployeeId = hrStaffEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });

            return true;
        }

        public bool ScrumMasterApproved(int scrumMasterEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestOvertimeApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestOvertime = ApprovalStatusRequestOvertime.ApprovedBySM,
                RequestOvertime = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });

            return true;
        }

        public bool ScrumMasterRejected(int scrumMasterEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestOvertimeApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestOvertime = ApprovalStatusRequestOvertime.RejectedBySM,
                RequestOvertime = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });

            return true;
        }
    }
    public enum ApprovalStatusRequestOvertime
    {
        Draft = 10,

        ApprovedBySM = 20,
        ApprovedByHR,

        RejectedBySM = 30,
        RejectedbyHR
    }

    public enum OvertimeType
    {
        Reimburse = 1,
        Paid_Quickleave
    }

}