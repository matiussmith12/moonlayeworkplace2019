﻿using Data.EntityFramework.SqlServer;
using Timesheets.Data.Abstractions;
using Timesheets.Data.Entities;

namespace Timesheets.Data.EntityFramework.SqlServer
{
    public class EmployeeDetailRepository : Repository<EmployeeDetail>, IEmployeeDetailRepository
    {
    }
}
