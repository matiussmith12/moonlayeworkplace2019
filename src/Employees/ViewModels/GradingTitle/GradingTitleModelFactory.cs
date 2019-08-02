using Employees.Data.Abstractions;
using Employees.ViewModels.EmployeeRole;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.GradingTitle
{
    internal class GradingTitleModelFactory
    {
        public GradingTitleModelFactory()
        {

        }

        internal GradingTitleIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var gradingRepo = storage.GetRepository<IGradingTitleRepository>();

            var queryGrading = gradingRepo.Query;

            return new GradingTitleIndexViewModel(gradingRepo.All(queryGrading, page, size));
        }
    }
}
