﻿namespace Reimburses.Data.Entities
{
    internal interface IApprovalRequestMedicalForm
    {
        bool ScrumMasterApproved(int scrumMasterEmployeeId);
        bool ScrumMasterRejected(int scrumMasterEmployeeId);

        bool HumanResourceDeptApproved(int hrStaffEmployeeId);
        bool HumanResourceDeptRejected(int hrStaffEmployeeId);
    }
}