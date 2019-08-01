using System;
using System.ComponentModel.DataAnnotations;
using Employees.Data.Entities;

namespace Employees.ViewModels.Department
{
    public class DepartmentCreateViewModel
    {
        public string DepartmentName { get; set; }

        internal Data.Entities.Department ToDepartmentEntity()
        {
            return new Data.Entities.Department
            {
                DepartmentName = this.DepartmentName
            };
        }
    }
}
