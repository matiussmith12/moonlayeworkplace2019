using Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkins.Data.Entities
{
    public class Checkin : Entity
    {
        //public Checkin()
        //{
        //    //this.Time = DateTimeOffset.Now;
        //}

        //public DateTimeOffset Time { get; set; }
        public string Location { get; set; }
        //public string Remark { get; set; }
        //public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        public bool IsLate { get; set; }

        public void VerifyLate(string lateTime)
        {
            var now = DateTime.Now;
            var datestring = now.ToString("yyyy-MM-dd");
            DateTimeOffset.TryParse(datestring + "T"+lateTime, out var late);
            this.IsLate = now > late.ToLocalTime();
        }

    }
}
