using System;
using System.Collections.Generic;
using AmDomain.Models;
using AmDomain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AmInfrastructure.Repositories
{
    public class AccountDetailRepository : IAccountDetailRepository
    {
        private DateTime _from;
        private DateTime _to;
        private string _keyword;
        private AmContext _db { set; get; }

        public AccountDetailRepository()
        {
        }
        public AccountDetail FindById(int id)
        {
            var accountDetail = _db.AccountDetail
                                .Where(ad => ad.Id == id)
                                .Include("Account")
                                .Include("AccountType")
                                .Include("Book")
                                .FirstOrDefault();
            return accountDetail;
        }

        public IEnumerable<AccountDetail> GetAll()
        {
            var accountDetails = _db.AccountDetail
                    .Include("Account")
                    .Include("AccountType")
                    .Include("Book")
                    .ToList();
            return accountDetails;
        }


        public void Add(AccountDetail item)
        {
            _db.AccountDetail.Add(item);
        }

        public void Update(AccountDetail item)
        {
            _db.AccountDetail.Update(item);
        }

        public void Delete(AccountDetail item)
        {
            _db.AccountDetail.Remove(item);
        }

        public IEnumerable<AccountDetail> GetByCondition(DateTime from, DateTime to, string keyword)
        {
            var accountDetails = _db.AccountDetail
                    .Where(ad => ad.SettlementDay >= from)
                    .Where(ad => ad.SettlementDay <= to)
                    .Where(ad => EF.Functions.Like(ad.Remarks,$"%{keyword}%"))
                    .Include("Account")
                    .Include("AccountType")
                    .Include("Book")
                    .ToList();
            return accountDetails;
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
