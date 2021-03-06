﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using Reimburses.Data.Entities;

namespace Reimburses.ViewModels.RequestMedical
{
    public class RequestMedicalCreateViewModel
    {
        public DateTimeOffset DateRequestMedical { get; set; }
        [Display(Name = "Medication Type")]
        [Required()]
        public string MedicationType { get; set; }
        [Display(Name = "Total Cost")]
        [Required()]
        public int TotalCostNominal { get; set; }
        public int TotalCostReimburse { get; set; }
        public IFormFile Image { get; set; }

        internal Data.Entities.RequestMedical ToRequestMedicalEntity()
        {
            return new Data.Entities.RequestMedical
            {
                DateRequestMedical = this.DateRequestMedical,
                MedicationType = this.MedicationType,
                TotalCostNominal = this.TotalCostNominal,
                TotalCostReimburse = this.TotalCostReimburse,
                //Image = this.Image,
            };
        }
    }
}
