using System;
using System.Collections.Generic;
namespace AmDomain.Models
{
    public class Account　:Entity
    {
        public string Email { set; get; }
        public string Password { set; get; }
        public string Salt { set; get; }

        public ICollection<AccountDetail> AccountDetail { set; get; }
    }
}
