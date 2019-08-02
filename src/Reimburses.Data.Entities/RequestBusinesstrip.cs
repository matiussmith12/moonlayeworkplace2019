using Data.Entities;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class RequestBusinesstrip : Entity, ISoftDelete
    {
        public DateTimeOffset DateBusinessTrip { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double TotalCostNominal { get; set; }
        public double TotalCostReimburse { get; set; }
        public string ImageUrl { get; set; }


        //Entity to  RequestBusinessTrip
        public int EmployeeId { get; set; }


        

        public bool IsDeleted { get; set; }
        public DateTimeOffset? Deleted { get; set; }
        public string DeleteBy { get; set; }

        public virtual ICollection<RequestBusinesstripApprovalHistory> ApprovalHistory { get; set; }

        public bool HumanResourceDeptApproved(int hrStaffEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestBusinesstripApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestBusinesstrip = ApprovalStatusRequestBusinesstrip.ApprovedByHR,
                RequestBusinesstrip = this,
                EmployeeId = hrStaffEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });

            return true;
        }

        public bool HumanResourceDeptRejected(int hrStaffEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestBusinesstripApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestBusinesstrip = ApprovalStatusRequestBusinesstrip.RejectedbyHR,
                RequestBusinesstrip = this,
                EmployeeId = hrStaffEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });

            return true;
        }

        public bool ScrumMasterApproved(int scrumMasterEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestBusinesstripApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestBusinesstrip = ApprovalStatusRequestBusinesstrip.ApprovedBySM,
                RequestBusinesstrip = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });
            return true;
        }

        public bool ScrumMasterRejected(int scrumMasterEmployeeId, string currentUsername)
        {
            this.ApprovalHistory.Add(new RequestBusinesstripApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestBusinesstrip = ApprovalStatusRequestBusinesstrip.RejectedBySM,
                RequestBusinesstrip = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = currentUsername
            });
            return true;
        }
    }
    public enum ApprovalStatusRequestBusinesstrip
    {
        Draft = 10,
        ApprovedBySM = 20,
        ApprovedByHR,
        RejectedBySM = 30,
        RejectedbyHR
    }


}


