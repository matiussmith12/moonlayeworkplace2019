using Checkins.Data.Abstractions;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkins.ViewModels.Checkin
{
    internal class CheckinModelFactory
    {
        public CheckinModelFactory()
        {

        }

        internal CheckinIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var checkinRepo = storage.GetRepository<ICheckinRepository>();

            return new CheckinIndexViewModel(checkinRepo.All(page, size).Select(o=> new CheckinDto(o)));
        }
    }
}
