using System.Collections.Generic;
using Employees.Data.Entities;

namespace Employees.ViewModels.Education
{
    public class EducationIndexViewModel
    {
        public EducationIndexViewModel(IEnumerable<Data.Entities.Education> data)
        {
            Educations = data ?? new List<Data.Entities.Education>();
        }

        public IEnumerable<Data.Entities.Education> Educations { get; }
    }
}