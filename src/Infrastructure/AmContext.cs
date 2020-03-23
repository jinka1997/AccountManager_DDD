using System;
using Microsoft.EntityFrameworkCore;
using AmDomain.Models;
namespace AmInfrastructure
{
    public class AmContext : DbContext
    {
        public DbSet<Account> Accounts { set; get; }
        public DbSet<AccountDetail> AccountDetails { set; get; }
        public DbSet<AccountType> AccountTypes { set; get; }
        public DbSet<Book> Books { set; get; }
    }
}
