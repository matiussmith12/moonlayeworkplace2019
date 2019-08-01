using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.WorkPlacement
{
    public class WorkPlacementUpdateViewModel
    {
        public WorkPlacementUpdateViewModel()
        {

        }

        public string WorkLocation { get; set; }
        public string OfficeAddress { get; set; }

        internal Data.Entities.WorkPlacement ToWorkEntity(Data.Entities.WorkPlacement entity)
        {
            entity.WorkLocation = this.WorkLocation;
            entity.OfficeAddress = this.OfficeAddress;

            return entity;
        }
    }
}
