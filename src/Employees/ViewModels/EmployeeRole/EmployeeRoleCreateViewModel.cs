using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employees.ViewModels.EmployeeRole
{
    public class EmployeeRoleCreateViewModel
    {

        [Required()]

        public string PositionTitle { get; set; }
        public int GroupId { get; set; }

        internal Data.Entities.EmployeeRole ToRoleEntity()
        {
            return new Data.Entities.EmployeeRole
            {
                PositionTitle = this.PositionTitle,
                GroupId = this.GroupId
            };
        }

    }
}
