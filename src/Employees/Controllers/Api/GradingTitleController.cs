using Barebone.Controllers;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.GradingTitle;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees.Controllers.Api
{
    [Route("api/grading")]
    public class GradingTitleController : Barebone.Controllers.ControllerBase
    {
        public GradingTitleController(IStorage storage) : base(storage)
        {

        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<GradingTitle> data = new GradingTitleModelFactory().LoadAll(this.Storage, page, size)?.Gradings;
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
            var repo = this.Storage.GetRepository<IGradingTitleRepository>();

            GradingTitle grad = repo.WithKey(id);
            if (grad == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = grad });
        }

        [HttpPost]
        public IActionResult Post(GradingTitleCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                GradingTitle grad = model.ToGradingEntity();
                var repo = this.Storage.GetRepository<IGradingTitleRepository>();

                repo.Create(grad, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true, data = grad });
            }

            return BadRequest(new { success = false });
        }



        [HttpPut("{id:int}")]
        public IActionResult Put(int id, GradingTitleUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IGradingTitleRepository>();

            GradingTitle grad= repo.WithKey(id);
            if (grad == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToGradingEntity(grad);
                repo.Edit(grad, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = "Data berhasil diperbaharui" });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IGradingTitleRepository>();

            GradingTitle grad= repo.WithKey(id);
            if (grad == null)
                return this.NotFound(new { success = false });

            repo.Delete(grad, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = "Data berhasil dihapus" });
        }
    }
}
