using System;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.QuickLeave
{
    public class QuickLeaveUpdateViewModel
    {
        public QuickLeaveUpdateViewModel() { }


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

        internal Data.Entities.QuickLeave ToEntity(Data.Entities.QuickLeave entity, string username)
        {
            entity.Date = this.Date;
            entity.StartTime = this.StartTime;
            entity.FinishTime = this.FinishTime;
            entity.TotalOvertime = this.TotalOvertime;
            entity.Purpose = this.Purpose;
           // entity.DepartmentId = this.DepartmentId;
          //  entity.GroupId = this.GroupId;
            entity.Note = this.Note;
            entity.ProjectName = this.ProjectName;
            entity.RequestTo = this.RequestTo;
            entity.Modified = DateTime.Now;
            entity.ModifiedBy = username;

            return entity;
        }
    }
}
