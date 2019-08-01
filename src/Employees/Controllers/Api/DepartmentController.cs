using Barebone.Controllers;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.BankAccount;
using Employees.ViewModels.Department;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Barebone.Controllers;
using System.Text;

namespace Employees.Controllers.Api
{
    [Route("api/department")]
    public class DepartmentController : Barebone.Controllers.ControllerBase
    {
        public DepartmentController(IStorage storage) : base(storage)
        {

        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<Department> data = new DepartmentModelFactory().LoadAll(this.Storage, page, size)?.Departments;
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
        public IActionResult Post(DepartmentCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Department department = model.ToDepartmentEntity();
                var repo = this.Storage.GetRepository<IDepartmentRepository>();

                repo.Create(department, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true, data = department });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<IDepartmentRepository>();

            Department department = repo.WithKey(id);
            if (department == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = department });
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, DepartmentUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IDepartmentRepository>();

            Department department = repo.WithKey(id);
            if (department == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToDepartmentEntity(department);
                repo.Edit(department, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = "Data telah berhasil diperbaharui" });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IDepartmentRepository>();

            Department department = repo.WithKey(id);
            if (department == null)
                return this.NotFound(new { success = false });

            repo.Delete(department, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = "Data berhasil dihapus" });
        }
    }
}
