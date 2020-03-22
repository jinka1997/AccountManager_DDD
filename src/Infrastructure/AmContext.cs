using System;
using Microsoft.EntityFrameworkCore;
using AmDomain.Models;
namespace AmInfrastructure
{
    public class AmContext : DbContext
    {
        public AmContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Account> Account { set; get; }
        public DbSet<AccountDetail> AccountDetail { set; get; }
        public DbSet<AccountType> AccountType { set; get; }
        public DbSet<Book> Book { set; get; }
    }
}
