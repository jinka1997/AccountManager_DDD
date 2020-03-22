using System;
using System.Collections.Generic;
using AmDomain.Repositories;
namespace AmDomain.Models
{
    public class Book : Entity, IEquatable<Book>
    {
        public int UserId { private set; get; }
        public string Name { private set; get; }
        public int SortOrder { private set; get; }

        public User User { set; get; }
        public ICollection<AccountType> AccountType { set; get; }

        public static Book BookFactory(int userId, string name)
        {
            var book = new Book()
            {
                UserId = userId,
                Name = name
            };
            return book;
        }

        public void SetSortOrder(int newSortOrder)
        {
            this.SortOrder = newSortOrder;
        }

        public bool Equals(Book other)
        {
            if (this.UserId != other.UserId) { return false; }
            if (this.Name != other.Name) { return false; }
            return true;
        }
    }
}
