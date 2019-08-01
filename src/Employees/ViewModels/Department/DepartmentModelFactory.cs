using System;
using Employees.Data.Abstractions;
using Employees.ViewModels.BankAccount;
using Employees.ViewModels.Employee;
using ExtCore.Data.Abstractions;

namespace Employees.ViewModels.Department
{
    internal class DepartmentModelFactory
    {
        public DepartmentModelFactory()
        {
        }

        internal DepartmentIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var departmentRepo = storage.GetRepository<IDepartmentRepository>();

            return new DepartmentIndexViewModel(departmentRepo.All(page, size));
        }
    }
}