using Employees.Data.Abstractions;
using Employees.ViewModels.Group;
using Employees.ViewModels.Religion;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.WorkPlacement
{
    internal class WorkPlacementModelFactory
    {
        public WorkPlacementModelFactory()
        {

        }

        internal WorkPlacementIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var workRepo = storage.GetRepository<IWorkPlacementRepository>();

            var queryWork = workRepo.Query;

            return new WorkPlacementIndexViewModel(workRepo.All(queryWork,page, size));
        }
    }
}
