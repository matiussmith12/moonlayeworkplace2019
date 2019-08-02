using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.RequestBusinesstrip
{
    public class RequestBusinesstripCreateViewModel
    {
        public DateTimeOffset DateBusinessTrip { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int TotalCostNominal { get; set; }
        public int TotalCostReimburse { get; set; }
        public IFormFile Image { get; set; }
        internal Data.Entities.RequestBusinesstrip ToRequestBusinessTripEntity()
        {
            return new Data.Entities.RequestBusinesstrip
            {
                DateBusinessTrip = this.DateBusinessTrip,
                From = this.From,
                To = this.To,
                TotalCostNominal = this.TotalCostNominal,
                TotalCostReimburse = this.TotalCostReimburse,
                //Image = this.Image,
            };
        }
    }
}
