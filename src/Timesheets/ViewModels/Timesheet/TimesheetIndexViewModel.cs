using System.Collections.Generic;
using Timesheets.Data.Entities;

namespace Timesheets.ViewModels.Timesheet
{
    public class TimesheetIndexViewModel
    {
        public TimesheetIndexViewModel(IEnumerable<TimesheetDto> data)
        {
            Timesheets = data ?? new List<TimesheetDto>();
        }

        public IEnumerable<TimesheetDto> Timesheets { get; }
    }
}