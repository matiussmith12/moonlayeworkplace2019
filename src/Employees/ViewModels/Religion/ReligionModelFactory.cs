using Employees.Data.Abstractions;
using Employees.ViewModels.Group;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.Religion
{
    internal class ReligionModelFactory
    {
        public ReligionModelFactory()
        {

        }

        internal ReligionIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var religionRepo = storage.GetRepository<IReligionRepository>();

            var queryReligion = religionRepo.Query;

            return new ReligionIndexViewModel(religionRepo.All(queryReligion, page, size));
        }
    }
}
