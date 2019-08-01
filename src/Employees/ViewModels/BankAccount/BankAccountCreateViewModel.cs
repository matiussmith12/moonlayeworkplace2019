using System;
using System.ComponentModel.DataAnnotations;
using Employees.Data.Entities;

namespace Employees.ViewModels.BankAccount
{
    public class BankAccountCreateViewModel
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string ReceiverName { get; set; }

        internal Data.Entities.BankAccount ToBankEntity()
        {
            return new Data.Entities.BankAccount
            {
                BankName = this.BankName,
                AccountNumber = this.AccountNumber,
                BranchName = this.BranchName,
                ReceiverName = this.ReceiverName
            };
        }
    }
}
