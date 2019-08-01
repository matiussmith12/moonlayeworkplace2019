using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.Religion
{
    public class ReligionIndexViewModel
    {
        public ReligionIndexViewModel(IEnumerable<Data.Entities.Religion> data)
        {
            Religions = data ?? new List<Data.Entities.Religion>();
        }

        public IEnumerable<Data.Entities.Religion> Religions { get; }
    }
}
