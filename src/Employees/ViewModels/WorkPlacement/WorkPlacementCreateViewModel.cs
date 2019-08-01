using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employees.ViewModels.WorkPlacement
{
    public class WorkPlacementCreateViewModel
    {
        [Required()]
        public string WorkLocation { get; set; }
        public string OfficeAddress { get; set; }

        internal Data.Entities.WorkPlacement ToWorkEntity()
        {
            return new Data.Entities.WorkPlacement
            {
                WorkLocation = this.WorkLocation,
                OfficeAddress = this.OfficeAddress
            };
        }
    }
}
