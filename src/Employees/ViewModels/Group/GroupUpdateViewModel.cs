using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.Group
{
    public class GroupUpdateViewModel
    {
        public GroupUpdateViewModel()
        {

        }

        public string GroupName { get; set; }

        internal Data.Entities.Group ToGroupEntity(Data.Entities.Group group)
        {
            group.GroupName = GroupName;

            return group;
        }
    }
}
