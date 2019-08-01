using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.GradingTitle
{
    public class GradingTitleUpdateViewModel
    {
        public GradingTitleUpdateViewModel()
        {

        }

        public string GradingName { get; set; }

        internal Data.Entities.GradingTitle ToGradingEntity(Data.Entities.GradingTitle entity)
        {
            entity.GradingName = GradingName;

            return entity;
        }
    }
}
