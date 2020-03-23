using System;
using AmDomain.Models;

namespace AmDomain.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {

        int GetNewSortOrder(Book book);
        bool Exists(int userId, string name);
    }
}
