using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.EmployeeRole
{
    public class EmployeeRoleIndexViewModel
    {
        public EmployeeRoleIndexViewModel(IEnumerable<Data.Entities.EmployeeRole> data)
        {
            Roles = data ?? new List<Data.Entities.EmployeeRole>();
        }

        public IEnumerable<Data.Entities.EmployeeRole> Roles { get; set; }
    }
}
