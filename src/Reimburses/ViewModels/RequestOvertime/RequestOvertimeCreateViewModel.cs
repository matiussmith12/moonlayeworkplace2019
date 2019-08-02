using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.RequestOvertime
{
    public class RequestOvertimeCreateViewModel
    {

        [Required()]
        public OvertimeType OvertimeType { get; set; }
        public DateTimeOffset DateOvertime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int TotalOvertime { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public string ProjectName { get; set; }
        public string RequestTo { get; set; }
        public int TransportReimbursement { get; set; }
        public int MealReimbursement { get; set; }
        public IFormFile Image { get; set; }
        internal Data.Entities.RequestOvertime ToRequestOvertimeEntity()
        {
            return new Data.Entities.RequestOvertime
            {
                OvertimeType = this.OvertimeType,
                DateOvertime = this.DateOvertime,
                StartTime = this.StartTime,
                FinishTime = this.FinishTime,
                TotalOvertime = this.TotalOvertime,
                ProjectName = this.ProjectName,
                RequestTo = this.RequestTo,
                TransportReimbursement = this.TransportReimbursement,
                MealReimbursement = this.MealReimbursement,
                DepartmentId = this.DepartmentId,
                GroupId = this.GroupId
            };
        }
    }
}
