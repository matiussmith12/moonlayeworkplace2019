using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.Group
{
    public class GroupIndexViewModel
    {
        public GroupIndexViewModel(IEnumerable<Data.Entities.Group> data)
        {
            Groups = data ?? new List<Data.Entities.Group>();
        }

        public IEnumerable<Data.Entities.Group> Groups { get; }
    }
}
