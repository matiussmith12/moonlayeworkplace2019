using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.GradingTitle
{
    public class GradingTitleIndexViewModel
    {
        public GradingTitleIndexViewModel(IEnumerable<Data.Entities.GradingTitle> data)
        {
            Gradings = data ?? new List<Data.Entities.GradingTitle>();
        }

        public IEnumerable<Data.Entities.GradingTitle> Gradings { get; set; }
    }
}
