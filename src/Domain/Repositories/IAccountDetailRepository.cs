using System;
using AmDomain.Models;
using System.Collections.Generic;
namespace AmDomain.Repositories
{
    public interface IAccountDetailRepository : IRepository<AccountDetail>
    {
        IEnumerable<AccountDetail> GetByCondition(DateTime from, DateTime to, string keyword);
    }
}
