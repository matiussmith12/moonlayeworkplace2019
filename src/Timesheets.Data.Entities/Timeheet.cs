using Data.Entities;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;

namespace Timesheets.Data.Entities
{
    public class Timesheet : Entity, IStopAble
    {
        public DateTimeOffset TimesheetDate { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public int TotalTimeByTask { get; set; }
        public int TotalTimeToday { get; set; }
        public bool isStarted { get; set; }

        //Database Relation
        public int EmployeeId { get; set; }
        public int SprintId { get; set; }
        public virtual Sprint Sprint { get; set; }
        public int TaskId { get; set; }

        public void Stop()
        {
            EndTime = DateTimeOffset.UtcNow;
            isStarted = false;
            //TaskIsStarted = timesheet.Sprint.Tasks.FirstOrDefault(o => o.Id == timesheet.TaskId)?.isStarted = false;

            TotalTimeToday = (EndTime - StartTime).Minutes;
            TotalTimeByTask = (TotalTimeByTask + TotalTimeToday);
        }
    }
}
