using System;
using System.ComponentModel.DataAnnotations;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.QuickLeave
{
    public class QuickLeaveCreateViewModel
    {
        public DateTimeOffset Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int TotalOvertime { get; set; }
        public string Purpose { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }
        public string Note { get; set; }

        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public int QuickLeaveId { get; set; }


        internal Data.Entities.QuickLeave ToQuickLeaveEntity()
        {
            return new Data.Entities.QuickLeave
            {
                Date = this.Date,
                StartTime = this.StartTime,
                FinishTime = this.FinishTime,
                TotalOvertime = this.TotalOvertime,
                Purpose = this.Purpose,
                ProjectName = this.ProjectName,
                RequestTo = this.RequestTo,

                DepartmentId = this.DepartmentId,
                GroupId = this.GroupId,
                

                Note = this.Note
            };
        }
    }
}
