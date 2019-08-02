using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Checkins.ViewModels.Checkin
{
    public class CheckinCreateViewModels
    {
       
        public string Location { get; set; }
        public int EmployeeId { get; set; }
        public IFormFile Image { get; set; }

        internal Data.Entities.Checkin ToEntity()
        {
            return new Data.Entities.Checkin
            {

                Location = this.Location,
                EmployeeId = this.EmployeeId

            };
        }
    }
}
