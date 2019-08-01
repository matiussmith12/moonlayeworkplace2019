using System;
using System.ComponentModel.DataAnnotations;
using Timesheets.Data.Entities;

namespace Timesheets.ViewModels.Timesheet
{
    public class TimesheetCreateViewModel
    {
        public DateTimeOffset? TimesheetDate { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public int EmployeeId { get; set; }
        public int SprintId { get; set; }
        public int TaskId { get; set; }

        internal Data.Entities.Timesheet ToEntity()
        {
            //if()
            return new Data.Entities.Timesheet
            {
                TimesheetDate = this.TimesheetDate.GetValueOrDefault(),
                StartTime = this.StartTime.GetValueOrDefault(),
                isStarted = true,

                EmployeeId = this.EmployeeId,
                SprintId = this.SprintId,
                TaskId = this.TaskId
            };
        }

        internal bool TimesheetYesterday(DateTimeOffset TimesheetDate)
        {
            var today = TimesheetDate.Date;
            var yesterday = today.AddDays(-1);
            if (yesterday == null) return false;
            return true;
        }
    }
}
