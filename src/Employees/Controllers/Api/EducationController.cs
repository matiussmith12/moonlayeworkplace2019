using Barebone.Controllers;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.Education;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees.Controllers.Api
{
    [Route("api/education")]
    public class EducationController : Barebone.Controllers.ControllerBase
    {
        public EducationController(IStorage storage) : base(storage)
        {
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<Education> data = new EducationModelFactory().LoadAll(this.Storage, page, size)?.Educations;
            int count = data.Count();

            return Ok(new
            {
                success = true,
                data,
                count,
                totalPage = ((int)count / size) + 1
            });
        }

        [HttpPost]
        public IActionResult Post(EducationCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Education education = model.ToEducationEntity();
                var repo = this.Storage.GetRepository<IEducationRepository>();

                repo.Create(education, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true, data = education });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<IEducationRepository>();

            Education education = repo.WithKey(id);
            if (education == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = education });
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, EducationUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IEducationRepository>();

            Education education = repo.WithKey(id);
            if (education == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToEducationEntity(education);
                repo.Edit(education, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = "Data berhasil diperbaharui" });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IEducationRepository>();

            Education education = repo.WithKey(id);
            if (education == null)
                return this.NotFound(new { success = false });

            repo.Delete(education, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = "Data berhasil dihapus" });
        }
    }
}
