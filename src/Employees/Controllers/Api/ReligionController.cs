using Barebone.Controllers;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.GradingTitle;
using Employees.ViewModels.Religion;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees.Controllers.Api
{
    [Route("api/religion")]
    public class ReligionController : Barebone.Controllers.ControllerBase
    {
        public ReligionController(IStorage storage) : base(storage)
        {
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<Religion> data = new ReligionModelFactory().LoadAll(this.Storage, page, size)?.Religions;
            int count = data.Count();

            return Ok(new
            {
                success = true,
                data,
                count,
                totalPage = ((int)count / size) + 1
            });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<IReligionRepository>();

            Religion religion = repo.WithKey(id);
            if (religion == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = religion });
        }

        [HttpPost]
        public IActionResult Post(ReligionCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Religion religion = model.ToReligionEntity();
                var repo = this.Storage.GetRepository<IReligionRepository>();

                repo.Create(religion, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true, data = religion });
            }

            return BadRequest(new { success = false });
        }



        [HttpPut("{id:int}")]
        public IActionResult Put(int id, ReligionUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IReligionRepository>();

            Religion religion= repo.WithKey(id);
            if (religion == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToReligionEntity(religion);
                repo.Edit(religion, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = "Data berhasil diperbaharui" });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IReligionRepository>();

            Religion religion= repo.WithKey(id);
            if (religion == null)
                return this.NotFound(new { success = false });

            repo.Delete(religion, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = "Data berhasil dihapus" });
        }
    }
}
