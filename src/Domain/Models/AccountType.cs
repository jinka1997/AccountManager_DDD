using System;
using System.Collections.Generic;
namespace AmDomain.Models
{
    public class AccountType : Entity
    {
        public int BookId { set; get; }
        public string Name { set; get; }
        public int SortOrder { set; get; }

        public Book Book { set; get; }
    }
}
