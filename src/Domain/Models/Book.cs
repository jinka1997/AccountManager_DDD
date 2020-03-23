using System;
using System.Collections.Generic;
namespace AmDomain.Models
{
    public class Book : Entity
    {
        public int UserId { set; get; }
        public string Name { set; get; }
        public int SortOrder { set; get; }

        public User User { set; get; }
        public ICollection<AccountDetail> AccountDetail { set; get; }


        public static Book BookFactory(int userId, string name)
        {
            var book = new Book()
            {
                UserId = userId,
                Name = name
            };
            return book;
        }

        public void SetSortOrder(int sortOrder)
        {
            this.SortOrder = sortOrder;
        }
    }
}
