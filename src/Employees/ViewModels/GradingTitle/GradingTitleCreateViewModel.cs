using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employees.ViewModels.GradingTitle
{
    public class GradingTitleCreateViewModel
    {

        [Required()]

        public string GradingName { get; set; }

        internal Data.Entities.GradingTitle ToGradingEntity()
        {
            return new Data.Entities.GradingTitle
            {
                GradingName = this.GradingName
            };
        }

    }
}
