using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Timesheets.Data.Entities
{
    public class Task : Entity
    {
        public string TaskName { get; set; }
        public bool isStarted { get; set; }

        //Database Relation
        public int SprintId { get; set; }
        public virtual Sprint Sprint { get; set; }
        public void Start()
        {
            isStarted = true;
        }
        public void Stop()
        {
            isStarted = false;
        }
    }
}
