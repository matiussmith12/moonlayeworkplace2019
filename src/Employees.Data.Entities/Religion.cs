using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data.Entities
{
    public class Religion : Entity, ISoftDelete
    {

        public string ReligionName { get; set; }

        public bool IsDeleted { get; set; }
        public DateTimeOffset? Deleted { get; set; }
        public string DeleteBy { get; set; }
    }
}
