using System;
using Employees.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Employees.ViewModels.Department
{
    public class DepartmentUpdateViewModel
    {
        public DepartmentUpdateViewModel() { }

        public string DepartmentName { get; set; }

        internal Data.Entities.Department ToDepartmentEntity(Data.Entities.Department entity)
        {

            entity.DepartmentName = this.DepartmentName;

            //   entity.Image = this.Image;

            return entity;
        }
    }
}