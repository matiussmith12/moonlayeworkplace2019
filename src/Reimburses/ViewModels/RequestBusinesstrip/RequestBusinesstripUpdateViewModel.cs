using System;
using Microsoft.AspNetCore.Http;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.RequestBusinesstrip
{
    public class RequestBusinesstripUpdateViewModel
    {
        public RequestBusinesstripUpdateViewModel() { }

       
        public DateTimeOffset DateBusinessTrip { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int TotalCostNominal { get; set; }
        public int TotalCostReimburse { get; set; }
        public IFormFile Image { get; set; }

        internal Data.Entities.RequestBusinesstrip ToBusinessTripEntity(Data.Entities.RequestBusinesstrip entity, string username)
        {
            entity.DateBusinessTrip = this.DateBusinessTrip;
            entity.From = this.From;
            entity.To = this.To;
            entity.TotalCostNominal = this.TotalCostNominal;
            entity.TotalCostReimburse = this.TotalCostReimburse;  
            entity.Modified = DateTime.Now;
            entity.ModifiedBy = username;

            return entity;
        }
    }
}
