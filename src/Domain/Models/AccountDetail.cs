using System;
namespace AmDomain.Models
{
    public class AccountDetail : Entity
    {
        public int BookId { set; get; }
        public DateTimeOffset SettlementDay { set; get; }
        public int ItemNumber { set; get; }
        public int AccountTypeId { set; get; }
        public bool IsExpense { set; get; }
        public decimal Amount { set; get; }
        public string Remarks { set; get; }

        public AccountType AccountType { set; get; }
        public Book Book { set; get; }
    }
}
