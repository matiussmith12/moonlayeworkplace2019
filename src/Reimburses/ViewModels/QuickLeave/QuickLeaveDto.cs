using Employees.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reimburses.ViewModels.QuickLeave
{
    public class QuickLeaveDto
    {
        public QuickLeaveDto()
        {            
        }
        public QuickLeaveDto(Data.Entities.QuickLeave quickLeave)
        {
            DateRequest = quickLeave.Date;
            StartTime = quickLeave.StartTime;
            FinishTime = quickLeave.FinishTime;
            TotalOvertime = quickLeave.TotalOvertime;
            Purpose = quickLeave.Purpose;
            ProjectName = quickLeave.ProjectName;
            RequestTo = quickLeave.RequestTo;         
    }

        public DateTimeOffset DateRequest { get; }
        public DateTime StartTime { get; }
        public DateTime FinishTime { get; }
        public int TotalOvertime { get; }
        public string Purpose { get; }
        public string ProjectName { get; }
        public string RequestTo { get; }
        public DepartmentDto Department { get; set; }
        public GroupDto Group { get; set; }
    }

    public class DepartmentDto
    {
        public DepartmentDto()
        {
        }
        public DepartmentDto(Department department)
        {
            departmentName = department.DepartmentName;
        }

        public string departmentName { get; }
    }

    public class GroupDto
    {
        public GroupDto()
        {
        }
        public GroupDto(Group group)
        {
            groupName = group.GroupName;
        }
        public string groupName { get; }
    }
}
