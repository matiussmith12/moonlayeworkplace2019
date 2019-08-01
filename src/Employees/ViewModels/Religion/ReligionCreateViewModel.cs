using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employees.ViewModels.Religion
{
    public class ReligionCreateViewModel
    {
        [Required()]
        public string ReligionName { get; set; }

        internal Data.Entities.Religion ToReligionEntity()
        {
            return new Data.Entities.Religion
            {
                ReligionName = this.ReligionName
            };
        }
    }
}
