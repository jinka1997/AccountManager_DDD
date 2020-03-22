using System;
using System.Collections.Generic;
namespace AmDomain.Models
{
    public class User　:Entity
    {
        public string Email { set; get; }
        public string Password { set; get; }
        public string Salt { set; get; }

        public ICollection<Book> Book { set; get; }
    }
}
