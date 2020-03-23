using System;
using Microsoft.EntityFrameworkCore;
using AmDomain.Models;
namespace AmInfrastructure
{
    public class AmContext : DbContext
    {
        public DbSet<User> User { set; get; }
        public DbSet<AccountDetail> AccountDetail { set; get; }
        public DbSet<AccountType> AccountType { set; get; }
        public DbSet<Book> Book { set; get; }
    }
}
