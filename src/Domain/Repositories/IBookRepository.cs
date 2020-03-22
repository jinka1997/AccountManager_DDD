using System;
using AmDomain.Models;

namespace AmDomain.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        bool Exists(int userId, string name);
        int GetNewSortOrder(Book book);
    }
}
