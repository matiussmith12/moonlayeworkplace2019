using Timesheets.Data.Entities;
using System.Linq;
using Employees.Data.Entities;
using System;

namespace Timesheets.ViewModels.Timesheet
{
    public class TimesheetDto
    {
        public TimesheetDto(Data.Entities.Timesheet timesheet, Employee employee)
        {
            Id = timesheet.Id;
            EmployeeId = timesheet.EmployeeId;
            SprintId = timesheet.SprintId;
            TaskId = timesheet.TaskId;
            Date = timesheet.TimesheetDate;
            StartTime = timesheet.StartTime;
            EndTime = timesheet.EndTime;
            TotalTimeByTask = timesheet.TotalTimeByTask;
            TotalTimeToday = timesheet.TotalTimeToday;
            isStarted = timesheet.isStarted;
            TasksIsStarted = timesheet.Sprint.Tasks.FirstOrDefault(o => o.Id == timesheet.TaskId)?.isStarted;

            EmployeeName = employee.FirstName;
            ProjectName = timesheet.Sprint.Project.ProjectName;
            SprintNumber = timesheet.Sprint.SprintNumber;
            TaskName = timesheet.Sprint.Tasks.FirstOrDefault(o => o.Id == timesheet.TaskId)?.TaskName;
        }

        public int Id { get; }
        public int EmployeeId { get; }
        public int SprintId { get; }
        public int TaskId { get; }
        public DateTimeOffset Date { get; }
        public DateTimeOffset StartTime { get; }
        public DateTimeOffset EndTime { get; }
        public int TotalTimeByTask { get; }
        public int TotalTimeToday { get; }
        public string EmployeeName { get; }
        public string ProjectName { get; }
        public int SprintNumber { get; }
        public string TaskName { get; }
        public bool? isStarted { get; }
        public bool? TasksIsStarted { get; }
    }
}