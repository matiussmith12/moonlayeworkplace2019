using Barebone.Controllers;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.WorkPlacement;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees.Controllers.Api
{
    [Route("api/workplacement")]
    public class WorkPlacementController : Barebone.Controllers.ControllerBase
    {
        public WorkPlacementController(IStorage storage) : base(storage)
        {
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<WorkPlacement> data = new WorkPlacementModelFactory().LoadAll(this.Storage, page, size)?.Works;
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
            var repo = this.Storage.GetRepository<IWorkPlacementRepository>();

            WorkPlacement work = repo.WithKey(id);
            if (work == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = work });
        }

        [HttpPost]
        public IActionResult Post(WorkPlacementCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                WorkPlacement work = model.ToWorkEntity();
                var repo = this.Storage.GetRepository<IWorkPlacementRepository>();

                repo.Create(work, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true, data = work });
            }

            return BadRequest(new { success = false });
        }



        [HttpPut("{id:int}")]
        public IActionResult Put(int id, WorkPlacementUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IWorkPlacementRepository>();

            WorkPlacement work= repo.WithKey(id);
            if (work == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToWorkEntity(work);
                repo.Edit(work, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = "Data berhasil diperbaharui" });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IWorkPlacementRepository>();

            WorkPlacement work = repo.WithKey(id);
            if (work == null)
                return this.NotFound(new { success = false });

            repo.Delete(work, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = "Data berhasil dihapus" });
        }
    }
}
