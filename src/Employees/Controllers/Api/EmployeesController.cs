using Barebone.Controllers;
using Barebone.Services;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.Employee;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Controllers.Api
{
   // [Authorize]
    [Route("api/employees")]
    public class EmployeesController : Barebone.Controllers.ControllerBase
    {
        private readonly IImageService _imageService;
        private readonly IConfiguration _configuration;

        public EmployeesController(IStorage storage, IImageService imageService, IConfiguration configuration) : base(storage)
        {
            _imageService = imageService;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<Employee> data = new EmployeeModelFactory().LoadAll(this.Storage, page, size)?.Employees;
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
        public async Task<IActionResult> Post(EmployeeCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Employee employee = model.ToEntity();
                var repo = this.Storage.GetRepository<IEmployeeRepository>();

                //var imageUrl = await _imageService.UploadImageAsync(model.Image);

                //employee.ImageUrl = imageUrl.ToString();
                repo.Create(employee, GetCurrentUserName());

                this.Storage.Save();

                return Ok(new { success = true, data = employee });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<IEmployeeRepository>();

            Employee employee = repo.WithKey(id);
            if (employee == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = employee });
        }


        [HttpPut("EditedByHRD {id:int}")]
        public async Task<IActionResult> Put(int id, EmployeeUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IEmployeeRepository>();

            Employee employee = repo.WithKey(id);
            if (employee == null)
                return this.NotFound(new { success = false });


            if (this.ModelState.IsValid)
            {
                model.ToEntity(employee);
                repo.Edit(employee, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = "Data berhasil diperbaharui" });
            }

            return BadRequest(new { success = false });
        }
        [HttpPut("EditByUser {id:int}")]
        public async Task<IActionResult> Edit(int id, EmployeeDtoUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IEmployeeRepository>();

            try
            {
                Employee employee = repo.WithKey(id);
                if (employee == null)
                    return this.NotFound(new { success = false });

                if (this.ModelState.IsValid)
                {
                    model.ToEntity(employee);
                    var imageUrl = await _imageService.UploadImageAsync(model.Image);

                    employee.ImageUrl = imageUrl.ToString();
                    repo.Edit(employee, GetCurrentUserName());
                    this.Storage.Save();

                    return Ok(new { success = "Data berhasil diperbaharui" });
                }

            }
            catch (Exception e)
            {
                throw e;
            }


                

                return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            
            var repo = this.Storage.GetRepository<IEmployeeRepository>();

            Employee employee = repo.WithKey(id);
            if (employee == null)
                return this.NotFound(new { success = false });

            repo.Delete(employee, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = "Data berhasil dihapus" });
        }

        [HttpGet("masterdata")]
        public IActionResult MasterData()
        {
            return Ok(new
            {
                genderType = Enum.GetValues(typeof(Gender)).Cast<Gender>().Select(g => new { id = g, name = g.ToString() }),
                statusWorker = Enum.GetValues(typeof(EmployeeStatus)).Cast<EmployeeStatus>().Select(s => new { id = s, name = s.ToString() }),
                maritalStatus = Enum.GetValues(typeof(MaritalStatus)).Cast<MaritalStatus>().Select(m => new { id = m, name = m.ToString() })
            });
        }

        [HttpGet("dto{id:int}")]
        public IActionResult GetEmployeeById([FromRoute] int id)
        {
            var employeeRepository = this.Storage.GetRepository<IEmployeeRepository>();
            var employee = employeeRepository.WithKey(id);

            var workRepository = this.Storage.GetRepository<IWorkPlacementRepository>();
            var work = workRepository.WithKey(employee.WorkPlacementId);

            var departmentRepository = this.Storage.GetRepository<IDepartmentRepository>();
            var department = departmentRepository.WithKey(employee.DepartmentId);

            var roleRepository = this.Storage.GetRepository<IEmployeeRoleRepository>();
            var role = roleRepository.WithKey(employee.EmployeeRoleId);

            var bankRepository = this.Storage.GetRepository<IBankAccountRepository>();
            var bank = bankRepository.WithKey(employee.BankAccountId);


            var result = new EmployeeDto(employee)
            {
                WorkPlacement = new WorkPlacementDto(work),
                Department = new DepartmentDto(department),
                PositionTitle = new PositionDto(role),
                Bank = new BankDto(bank)
            };



            return Ok(result);
        }
    }
}
