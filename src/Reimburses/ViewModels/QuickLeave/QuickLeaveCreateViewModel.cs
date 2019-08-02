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
        public string Purpose { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }
        public string Note { get; set; }




        internal Data.Entities.QuickLeave ToQuickLeaveEntity()
        {
            return new Data.Entities.QuickLeave
            {
                Date = this.Date,
                StartTime = this.StartTime,
                FinishTime = this.FinishTime,
                TotalOvertime = (this.FinishTime - this.StartTime).Hours,
                Purpose = this.Purpose,
                ProjectName = this.ProjectName,
                RequestTo = this.RequestTo,


                Note = this.Note
            };
        }
    }
}
