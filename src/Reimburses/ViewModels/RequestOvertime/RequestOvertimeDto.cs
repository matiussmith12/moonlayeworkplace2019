using Employees.Data.Entities;
using Reimburses.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reimburses.ViewModels.RequestOvertime
{
    public class RequestOvertimeDto
    {
        public RequestOvertimeDto()
        {

        }
        public RequestOvertimeDto(Data.Entities.RequestOvertime requestOvertime)
        {
            OvertimeType = requestOvertime.OvertimeType;
            DateOvertime = requestOvertime.DateOvertime;
            StartTime = requestOvertime.StartTime;
            FinishTime = requestOvertime.FinishTime;
            TotalOvertime = requestOvertime.TotalOvertime;
            DepartmentId = requestOvertime.DepartmentId;
            GroupId = requestOvertime.GroupId;
            ProjectName = requestOvertime.ProjectName;
            RequestTo = requestOvertime.RequestTo;
            TransportReimbursement = requestOvertime.TransportReimbursement;
            MealReimbursement = requestOvertime.MealReimbursement;            
        }

        public OvertimeType OvertimeType { get; }
        public DateTimeOffset DateOvertime { get; }
        public DateTime StartTime { get; }
        public DateTime FinishTime { get; }
        public int TotalOvertime { get; }
        public int DepartmentId { get; }
        public int GroupId { get; }
        public string ProjectName { get; }
        public string RequestTo { get; }
        public int TransportReimbursement { get; }
        public int MealReimbursement { get; }
        public GroupDto Group { get; set; }
        public DepartmentDto Department { get; set; }
    }

    public class GroupDto
    {
        public GroupDto()
        {
        }

        public GroupDto(Group group)
        {
            GroupName = group.GroupName;
        }

        public string GroupName { get; }
    }
    public class DepartmentDto
    {
        public DepartmentDto()
        {
        }

        public DepartmentDto(Department department)
        {
            DepartmentName = department.DepartmentName;
        }
        public string DepartmentName { get; }
    }

}
