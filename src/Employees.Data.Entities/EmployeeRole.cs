using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Employees.Data.Entities
{
    public class EmployeeRole : Entity, ISoftDelete
    {
        public string PositionTitle { get; set; }


        //Employee Role to Group
        public int GroupId { get; set; } 
        public virtual Group Group { get; set; }

        //Role to Employee
        public ICollection<Employee> Employees { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTimeOffset? Deleted { get; set; }

        public string DeleteBy { get; set; }
    }
}
