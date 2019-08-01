using Data.Abstractions;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data.Abstractions
{
    public interface IEmployeeRoleRepository : IRepository<EmployeeRole>
    {
    }
}
