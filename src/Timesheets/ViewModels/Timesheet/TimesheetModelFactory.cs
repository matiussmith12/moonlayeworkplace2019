using System;
using Timesheets.Data.Abstractions;
using ExtCore.Data.Abstractions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Employees.Data.Abstractions;

namespace Timesheets.ViewModels.Timesheet
{
    internal class TimesheetModelFactory
    {
        public TimesheetModelFactory()
        {
        }

        internal TimesheetIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var timesheetRepo = storage.GetRepository<ITimesheetRepository>();
            var employeeRepo = storage.GetRepository<IEmployeeRepository>();

            var queryTimesheet = timesheetRepo.Query.Include(o => o.Sprint.Tasks).Include(ti => ti.Sprint.Project);
            var timesheetList = timesheetRepo.All(queryTimesheet, page, size);
            var selectedEmployeeIds = timesheetList.Select(o => o.EmployeeId).Distinct();
            var selectedEmployees = employeeRepo.Query.Where(o => selectedEmployeeIds.Contains(o.Id)).ToList();

            var data = (from o in timesheetList
                        join x in selectedEmployees on o.EmployeeId equals x.Id
                        select new TimesheetDto(o, x)).ToList();

            //var yesterday = from n in timesheetList
            //        group n by n.TimesheetDate into g
            //        select g.OrderByDescending(t => t.TimesheetDate).FirstOrDefault();

            return new TimesheetIndexViewModel(data);
        }
    }
}

