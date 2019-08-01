using System.Collections.Generic;
using Employees.Data.Entities;

namespace Employees.ViewModels.Department
{
    public class DepartmentIndexViewModel
    {
        public DepartmentIndexViewModel(IEnumerable<Data.Entities.Department> data)
        {
            Departments = data ?? new List<Data.Entities.Department>();
        }

        public IEnumerable<Data.Entities.Department> Departments { get; }
    }
}