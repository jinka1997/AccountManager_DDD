using System;
using System.Collections.Generic;
using AmDomain.Models;
using AmDomain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AmInfrastructure.Repositories
{
    public class AccountDetailRepository : Repository<AccountDetail>, IAccountDetailRepository
    {
        public AccountDetailRepository(AmContext context)
            : base(context)
        {
        }
        public override AccountDetail FindById(int id)
        {
            var accountDetail = _db.AccountDetail
                                .Where(ad => ad.Id == id)
                                .Include("Account")
                                .Include("AccountType")
                                .Include("Book")
                                .FirstOrDefault();
            return accountDetail;
        }

        public override IEnumerable<AccountDetail> GetAll()
        {
            var accountDetails = _db.AccountDetail
                    .Include("Account")
                    .Include("AccountType")
                    .Include("Book")
                    .ToList();
            return accountDetails;
        }

        public IEnumerable<AccountDetail> GetByCondition(DateTime from, DateTime to, string keyword)
        {
            var accountDetails = _db.AccountDetail
                    .Where(ad => ad.SettlementDay >= from)
                    .Where(ad => ad.SettlementDay <= to)
                    .Where(ad => EF.Functions.Like(ad.Remarks, $"%{keyword}%"))
                    .Include("Account")
                    .Include("AccountType")
                    .Include("Book")
                    .ToList();
            return accountDetails;
        }
    }
}
