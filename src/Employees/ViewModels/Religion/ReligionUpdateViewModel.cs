using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.Religion
{
    public class ReligionUpdateViewModel
    {
        public ReligionUpdateViewModel()
        {

        }

        public string ReligionName { get; set; }

        internal Data.Entities.Religion ToReligionEntity(Data.Entities.Religion entity)
        {
            entity.ReligionName = ReligionName;

            return entity;
        }
    }
}
