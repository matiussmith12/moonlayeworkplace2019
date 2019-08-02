using System;
using Employees.Data.Abstractions;
using ExtCore.Data.Abstractions;

namespace Employees.ViewModels.Employee
{
    internal class EmployeeModelFactory
    {
        public EmployeeModelFactory()
        {
        }

        internal EmployeeIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var employeeRepo = storage.GetRepository<IEmployeeRepository>();

            var queryEmployee = employeeRepo.Query;

            return new EmployeeIndexViewModel(employeeRepo.All(queryEmployee, page, size));
        }
    }
}