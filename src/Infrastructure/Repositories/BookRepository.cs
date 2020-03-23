using System;
using AmDomain.Repositories;
using AmDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace AmInfrastructure.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(AmContext context)
            :base (context)
        {
        }

        public bool Exists(int userId, string name)
        {
            var any = _dbSet.Any(v => v.UserId == userId && v.Name == name);
            return any;
        }

        public int GetNewSortOrder(Book book)
        {
            if (!_dbSet.Any(b => b.UserId == book.UserId)) { return 1; }
            var maxSortOrder = _dbSet.Where(v => v.UserId == book.UserId).Max(v => v.SortOrder);
            return maxSortOrder + 1;
        }
    }
}
