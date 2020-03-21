using System;
using System.Collections.Generic;
using AmDomain.Models;
using AmDomain.Repositories;
namespace Infrastructure.Repositories
{
    public class AccountDetailRepository : IAccountDetailRepository
    {


        public AccountDetailRepository()
        {
        }
        public AccountDetail FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(AccountDetail item)
        {
            throw new NotImplementedException();
        }

        public void Update(AccountDetail item)
        {
            throw new NotImplementedException();
        }

        public void Delete(AccountDetail item)
        {
            throw new NotImplementedException();
        }
    }
}
