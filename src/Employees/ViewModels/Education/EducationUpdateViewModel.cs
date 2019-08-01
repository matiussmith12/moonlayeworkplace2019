using System;
using Employees.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Employees.ViewModels.Education
{
    public class EducationUpdateViewModel
    {
        public EducationUpdateViewModel() { }

        public string LastEducation { get; set; }

        internal Data.Entities.Education ToEducationEntity(Data.Entities.Education entity)
        {

            entity.LastEducation = LastEducation;

            //   entity.Image = this.Image;

            return entity;
        }
    }
}