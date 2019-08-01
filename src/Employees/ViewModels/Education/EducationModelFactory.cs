using System;
using Employees.Data.Abstractions;
using Employees.ViewModels.BankAccount;
using Employees.ViewModels.Department;
using Employees.ViewModels.Employee;
using ExtCore.Data.Abstractions;

namespace Employees.ViewModels.Education
{
    internal class EducationModelFactory
    {
        public EducationModelFactory()
        {
        }

        internal EducationIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var educationRepo = storage.GetRepository<IEducationRepository>();

            return new EducationIndexViewModel(educationRepo.All(page, size));
        }
    }
}