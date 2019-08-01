using Barebone.Controllers;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.EmployeeRole;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees.Controllers.Api
{
    [Route("api/roles")]
    public class EmployeeRoleController : Barebone.Controllers.ControllerBase
    {
        public EmployeeRoleController(IStorage storage) : base(storage)
        {

        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<EmployeeRole> data = new EmployeeRoleModelFactory().LoadAll(this.Storage, page, size)?.Roles;
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
            var repo = this.Storage.GetRepository<IEmployeeRoleRepository>();

            EmployeeRole role = repo.WithKey(id);
            if (role == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = role });
        }

        [HttpPost]
        public IActionResult Post(EmployeeRoleCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                EmployeeRole role = model.ToRoleEntity();
                var repo = this.Storage.GetRepository<IEmployeeRoleRepository>();

                repo.Create(role, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true, data = role });
            }

            return BadRequest(new { success = false });
        }



        [HttpPut("{id:int}")]
        public IActionResult Put(int id, EmployeeRoleUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IEmployeeRoleRepository>();

            EmployeeRole role = repo.WithKey(id);
            if (role == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToRoleEntity(role);
                repo.Edit(role, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = "Data berhasil diperbaharui" });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IEmployeeRoleRepository>();

            EmployeeRole role = repo.WithKey(id);
            if (role == null)
                return this.NotFound(new { success = false });

            repo.Delete(role, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = "Data berhasil dihapus" });
        }
    }
}
