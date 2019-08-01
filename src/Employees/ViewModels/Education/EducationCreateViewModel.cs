using System;
using System.ComponentModel.DataAnnotations;
using Employees.Data.Entities;

namespace Employees.ViewModels.Education
{
    public class EducationCreateViewModel
    {
        public string LastEducation { get; set; }

        internal Data.Entities.Education ToEducationEntity()
        {
            return new Data.Entities.Education
            {
                LastEducation = this.LastEducation
            };
        }
    }
}
