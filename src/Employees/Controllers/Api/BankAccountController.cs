using Barebone.Controllers;
using Employees.Data.Abstractions;
using Employees.Data.Entities;
using Employees.ViewModels.BankAccount;
using Employees.ViewModels.Employee;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees.Controllers.Api
{
    [Route("api/bankaccounts")]
    public class BankAccountController : Barebone.Controllers.ControllerBase
    {
        public BankAccountController(IStorage storage) : base(storage)
        {

        }

        [HttpGet]
        public IActionResult Get(int page = 0, int size = 25)
        {
            IEnumerable<BankAccount> data = new BankAccountModelFactory().LoadAll(this.Storage, page, size)?.Accounts;
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
        public IActionResult Post(BankAccountCreateViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                BankAccount bankAccount = model.ToBankEntity();
                var repo = this.Storage.GetRepository<IBankAccountRepository>();

                repo.Create(bankAccount, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = true, data = bankAccount });
            }

            return BadRequest(new { success = false });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repo = this.Storage.GetRepository<IBankAccountRepository>();

            BankAccount bankAccount = repo.WithKey(id);
            if (bankAccount == null)
                return this.NotFound(new { success = false });

            return Ok(new { success = true, data = bankAccount });
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, BankAccountUpdateViewModel model)
        {
            var repo = this.Storage.GetRepository<IBankAccountRepository>();

            BankAccount bankAccount = repo.WithKey(id);
            if (bankAccount == null)
                return this.NotFound(new { success = false });

            if (this.ModelState.IsValid)
            {
                model.ToBankEntity(bankAccount);
                repo.Edit(bankAccount, GetCurrentUserName());
                this.Storage.Save();

                return Ok(new { success = "Data telah berhasil diperbaharui" });
            }

            return BadRequest(new { success = false });
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var repo = this.Storage.GetRepository<IBankAccountRepository>();

            BankAccount bankAccount = repo.WithKey(id);
            if (bankAccount == null)
                return this.NotFound(new { success = false });

            repo.Delete(bankAccount, GetCurrentUserName());
            this.Storage.Save();

            return Ok(new { success = "Data telah berhasil dihapus" });
        }
    }
}
