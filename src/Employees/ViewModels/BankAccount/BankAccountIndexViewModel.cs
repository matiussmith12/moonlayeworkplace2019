using System.Collections.Generic;
using Employees.Data.Entities;

namespace Employees.ViewModels.BankAccount
{
    public class BankAccountIndexViewModel
    {
        public BankAccountIndexViewModel(IEnumerable<Data.Entities.BankAccount> data)
        {
            Accounts = data ?? new List<Data.Entities.BankAccount>();
        }

        public IEnumerable<Data.Entities.BankAccount> Accounts { get; }
    }
}