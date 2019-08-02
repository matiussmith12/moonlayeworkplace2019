using Data.Entities;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;

namespace Reimburses.Data.Entities
{
    public class RequestMedical : Entity, ISoftDelete
    {
        public DateTimeOffset DateRequestMedical { get; set; }
        public string MedicationType { get; set; }
        public Double TotalCostNominal { get; set; }
        public Double TotalCostReimburse { get; set; }
        public string ImageUrl { get; set; }

        //Employee to RequestMedical
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


        public bool IsDeleted { get; set; }
        public DateTimeOffset? Deleted { get; set; }
        public string DeleteBy { get; set; }



        public Double GetTotalReimburseTaken()
        {
            return TotalCostReimburse = 0.8 * TotalCostNominal;
        }

        //approval
        public virtual ICollection<RequestMedicalApprovalHistory> ApprovalHistory { get; set; }


        public bool HumanResourceDeptApproved(int hrStaffEmployeeId, string CurrentUsername)
        {
            this.ApprovalHistory.Add(new RequestMedicalApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestMedical = ApprovalStatusRequestMedical.ApprovedByHR,
                RequestMedical = this,
                EmployeeId = hrStaffEmployeeId,
                Created = DateTime.Now,
                CreatedBy = CurrentUsername
            });
            return true;
        }
        public bool HumanResourceDeptRejected(int hrStaffEmployeeId, string CurrentUsername)
        {
            this.ApprovalHistory.Add(new RequestMedicalApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestMedical = ApprovalStatusRequestMedical.RejectedbyHR,
                RequestMedical = this,
                EmployeeId = hrStaffEmployeeId,
                Created = DateTime.Now,
                CreatedBy = CurrentUsername
            });
            return true;
        }

        public bool ScrumMasterApproved(int scrumMasterEmployeeId, string CurrentUsername)
        {
            this.ApprovalHistory.Add(new RequestMedicalApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestMedical = ApprovalStatusRequestMedical.ApprovedBySM,
                RequestMedical = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = CurrentUsername
            });
            return true;
        }

        public bool ScrumMasterRejected(int scrumMasterEmployeeId, string CurrentUsername)
        {
            this.ApprovalHistory.Add(new RequestMedicalApprovalHistory
            {
                ApprovalDate = DateTime.Now,
                ApprovalStatusRequestMedical = ApprovalStatusRequestMedical.RejectedBySM,
                RequestMedical = this,
                EmployeeId = scrumMasterEmployeeId,
                Created = DateTime.Now,
                CreatedBy = CurrentUsername
            });
            return true;
        }
    }
    public enum ApprovalStatusRequestMedical
    {
        Draft = 10,

        ApprovedBySM = 20,
        ApprovedByHR,

        RejectedBySM = 30,
        RejectedbyHR
    }

    
}