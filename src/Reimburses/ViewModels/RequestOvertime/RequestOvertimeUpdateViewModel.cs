using System;
using Microsoft.AspNetCore.Http;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.RequestOvertime
{
    public class RequestOvertimeUpdateViewModel
    {
        public RequestOvertimeUpdateViewModel() { }

    //    private readonly Data.Entities.RequestOvertime _entity;

        public OvertimeType OvertimeType { get; set; }
        public DateTimeOffset DateOvertime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int TotalOvertime { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }
        public int TransportReimbursement { get; set; }
        public int MealReimbursement { get; set; }
        public IFormFile Image { get; set; }

        internal Data.Entities.RequestOvertime ToRequestOvertimeEntity(Data.Entities.RequestOvertime entity, string username)
        {
        
            entity.OvertimeType = this.OvertimeType;
            entity.StartTime = this.StartTime;
            entity.FinishTime = this.FinishTime;
            entity.TotalOvertime = this.TotalOvertime;
            entity.ProjectName = this.ProjectName;
            entity.RequestTo = this.RequestTo;
            entity.TransportReimbursement = this.TransportReimbursement;
            entity.MealReimbursement = this.MealReimbursement;

            entity.Modified = DateTime.Now;
            entity.ModifiedBy = username;

            return entity;
        }
    }
}
