using System;
using System.Collections.Generic;
namespace AmDomain.Models
{
    public class AccountType : Entity
    {
        public int AccountId { set; get; }
        public string Name { set; get; }
        public int SortOrder { set; get; }

        public Account Account { set; get; }
        public ICollection<AccountDetail> AccountDetail { set; get; }

    }
}
