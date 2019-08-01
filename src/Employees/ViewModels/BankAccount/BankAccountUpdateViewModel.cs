using System;
using Employees.Data.Entities;
using Microsoft.AspNetCore.Http;

namespace Employees.ViewModels.BankAccount
{
    public class BankAccountUpdateViewModel
    {
        public BankAccountUpdateViewModel() { }

        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string ReceiverName { get; set; }

        internal Data.Entities.BankAccount ToBankEntity(Data.Entities.BankAccount account)
        {

            account.BankName = this.BankName;
            account.AccountNumber = this.AccountNumber;
            account.BranchName = this.BranchName;
            account.ReceiverName = this.ReceiverName;
            
            //   entity.Image = this.Image;

            return account;
        }
    }
}