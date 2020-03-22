using System;
using System.Collections.Generic;
using AmDomain.Models;
using AmDomain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace AmInfrastructure.Repositories
{
    public class AccountDetailRepository : IAccountDetailRepository
    {
        private AmContext _db;

        public AccountDetailRepository(AmContext context)
        {
            _db = context;
        }
        public AccountDetail FindById(int id)
        {
            var accountDetail = _db.AccountDetails
                                .Where(ad => ad.Id == id)
                                .Include("Account")
                                .Include("AccountType")
                                .Include("Book")
                                .FirstOrDefault();
            return accountDetail;
        }

        public IEnumerable<AccountDetail> GetAll()
        {
            var accountDetails = _db.AccountDetails
                    .Include("Account")
                    .Include("AccountType")
                    .Include("Book")
                    .ToList();
            return accountDetails;
        }


        public void Add(AccountDetail item)
        {
            _db.AccountDetails.Add(item);
        }

        public void Update(AccountDetail item)
        {
            var entity = this.FindById(item.Id);
            if (entity == null)
            {
                throw new Exception();
            }
            entity = item;
        }

        public void Delete(AccountDetail item)
        {
            _db.AccountDetails.Remove(item);
        }

        public IEnumerable<AccountDetail> GetByCondition(DateTime from, DateTime to, string keyword)
        {
            var accountDetails = _db.AccountDetails
                    .Where(ad => ad.SettlementDay >= from)
                    .Where(ad => ad.SettlementDay <= to)
                    .Where(ad => EF.Functions.Like(ad.Remarks,$"%{keyword}%"))
                    .Include("Account")
                    .Include("AccountType")
                    .Include("Book")
                    .ToList();
            return accountDetails;
        }
    }
}
