using Checkins.Data.Entities;
using Microsoft.CodeAnalysis;
using System;

namespace Checkins.ViewModels.Checkin
{
    public class CheckinDto
    {
        public CheckinDto(Data.Entities.Checkin checkin)
        {
            LateStatus = checkin.IsLate ? "Late" : "On Time";
            Location = checkin.Location;
            ImageUrl = checkin.ImageUrl;
            Time = checkin.Created;

        }

        public string LateStatus { get; }
        public string Location { get; }
        public string ImageUrl { get; }
        public DateTimeOffset Time { get; }
    }
}