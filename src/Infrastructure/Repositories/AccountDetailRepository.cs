﻿using System;
using System.Collections.Generic;
using AmDomain.Models;
using AmDomain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace AmInfrastructure.Repositories
{
    public class AccountDetailRepository : IAccountDetailRepository
    {
        private DateTime _from;
        private DateTime _to;
        private string _keyword;
        private AmContext _db { set; get; }

        public AccountDetailRepository(AmContext context)
        {
            _db = context;
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
            var entity = this.FindById(item.Id);
            if (entity == null)
            {
                throw new Exception();
            }
            entity = item;
        }

        public void Delete(AccountDetail item)
        {
            _db.AccountDetail.Remove(item);
        }
    }
}
