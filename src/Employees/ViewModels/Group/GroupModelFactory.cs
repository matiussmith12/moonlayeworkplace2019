using Employees.Data.Abstractions;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ViewModels.Group
{
    internal class GroupModelFactory
    {
        public GroupModelFactory()
        {

        }

        internal GroupIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var groupRepo = storage.GetRepository<IGroupRepository>();

            var queryGroup = groupRepo.Query;

            return new GroupIndexViewModel(groupRepo.All(queryGroup, page, size));
        }
    }
}
