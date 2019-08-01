using Data.EntityFramework.SqlServer;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data.EntityFramework.SqlServer
{
    public class EmployeeRoleRepository : Repository<EmployeeRole>, IEmployeeRoleRepository
    {
    }
}
