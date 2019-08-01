using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.EmployeeRole
{
    public class EmployeeRoleUpdateViewModel
    {
        public EmployeeRoleUpdateViewModel()
        {

        }

        public string PositionTitle{ get; set; }

        internal Data.Entities.EmployeeRole ToRoleEntity(Data.Entities.EmployeeRole role)
        {
            role.PositionTitle = PositionTitle;

            return role;
        }
    }
}
