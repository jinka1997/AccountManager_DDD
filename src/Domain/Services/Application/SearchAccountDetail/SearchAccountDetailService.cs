using System;
using System.Linq;
using AmDomain.Models;
using AmDomain.Repositories;
using System.Collections.Generic;
namespace AmDomain.Services.Application.SearchAccountDetail
{
    public class SearchAccountDetailService
    {
        public SearchAccountDetailService()
        {
        }
        public IEnumerable<AccountDetail> GetAccountDetailByCondition(DateTime from, DateTime to, string keyword)
        {
            //var repos = new IAccountDetailRepository();
            //return repos.GetByCondition(from, to, keyword);

            return null;
        }
    }
}
