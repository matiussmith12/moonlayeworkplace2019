using Data.Entities;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class QuickLeave : Entity, ISoftDelete
    {
        public DateTimeOffset Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int TotalOvertime { get; set; }
        public string Purpose { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }
        public string Note { get; set; }
        


        // Entity Relational

        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int EmployeeId { get; set; }

        public bool IsDeleted { get; set; }
        public DateTimeOffset? Deleted { get; set; }
        public string DeleteBy { get; set; }

        public void GetTotalTimeTaken()
        {
            TotalOvertime = (FinishTime - StartTime).Hours;
        }



        public virtual ICollection<QuickLeaveApprovalHistory> ApprovalHistory { get; set; }

        public bool HumanResourceDeptApproved(int hrStaffEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new QuickLeaveApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusQuickLeave = ApprovalStatusQuickLeave.ApprovedByHR,
                QuickLeave = this,
                EmployeeId = hrStaffEmployeeId,
                CreatedBy = currentUsername,
                Created = DateTime.Now
            });

            return true;
        }

        public bool HumanResourceDeptRejected(int hrStaffEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new QuickLeaveApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusQuickLeave = ApprovalStatusQuickLeave.RejectedbyHR,
                QuickLeave = this,
                EmployeeId = hrStaffEmployeeId,
                 CreatedBy = currentUsername,
                Created = DateTime.Now
            });

            return true;
        }

        public bool ScrumMasterApproved(int scrumMasterEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new QuickLeaveApprovalHistory
            {
                ApprovalDate = DateTime.Now, 
                ApprovalStatusQuickLeave = ApprovalStatusQuickLeave.ApprovedBySM,
                QuickLeave = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
               
            });

            return true;
        }

        public bool ScrumMasterRejected(int scrumMasterEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new QuickLeaveApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusQuickLeave = ApprovalStatusQuickLeave.RejectedBySM,
                QuickLeave = this,
                EmployeeId = scrumMasterEmployeeId,
                CreatedBy = currentUsername,
                Created = DateTime.Now
            });

            return true;
        }
    }
    public enum ApprovalStatusQuickLeave
    {
        Draft = 10,

        ApprovedBySM = 20,
        ApprovedByHR,

        RejectedBySM = 30,
        RejectedbyHR
    }


}
   
      
