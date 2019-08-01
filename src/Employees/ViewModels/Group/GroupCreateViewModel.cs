using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employees.ViewModels.Group
{
    public class GroupCreateViewModel
    {
        [Required()]
        public string GroupName { get; set; }

        internal Data.Entities.Group ToGroupEntity()
        {
            return new Data.Entities.Group  
            {
                GroupName = this.GroupName
            };
        }
    }
}
