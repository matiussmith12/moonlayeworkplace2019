using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Employees.Data.Entities
{
    public class Group : Entity, ISoftDelete
    {
        public string GroupName { get; set; }


        //Group to Role
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }


        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTimeOffset? Deleted { get; set; }

        public string DeleteBy { get; set; }
    }
}
