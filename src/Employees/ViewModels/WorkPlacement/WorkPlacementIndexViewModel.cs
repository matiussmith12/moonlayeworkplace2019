using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.WorkPlacement
{
    public class WorkPlacementIndexViewModel
    {
        public WorkPlacementIndexViewModel(IEnumerable<Data.Entities.WorkPlacement> data)
        {
            Works = data ?? new List<Data.Entities.WorkPlacement>();
        }

        public IEnumerable<Data.Entities.WorkPlacement> Works { get; }
    }
}
