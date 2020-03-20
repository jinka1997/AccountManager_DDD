using System;
using AmDomain.Models;
using System.Collections.Generic;
namespace AmDomain.Repositories
{
    public interface IAccountDetailRepository : IRepository<AccountDetail>
    {

        AccountDetail FindById(int id);

        IEnumerable<AccountDetail> GetAll();
        void Add(AccountDetail item);
        void Update(AccountDetail item);
        void Delete(AccountDetail item);
    }
}
