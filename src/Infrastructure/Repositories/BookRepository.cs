using System;
using System.Collections.Generic;
using AmDomain.Models;
using AmDomain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AmInfrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private AmContext _context;
        public BookRepository(AmContext context)
        {
            _context = context;
        }

        public void Add(Book item)
        {
            _context.Book.Add(item);
        }

        public void Delete(Book item)
        {
            _context.Book.Remove(item);
        }

        public bool Exists(int userId, string name)
        {
            bool exists = !_context.Book.Any(b => b.UserId == userId && b.Name == name);
            return exists;
        }

        public Book FindById(int id)
        {
            var item = _context.Book.Find(id);
            return item;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Book.ToList();
        }

        public int GetNewSortOrder(Book book)
        {
            if (!_context.Book.Any(b => b.UserId == book.UserId)) { return 1; }
            var maxSortOrder = _context.Book.Where(b => b.UserId == book.UserId).Max(b => b.SortOrder);
            return maxSortOrder + 1;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(Book item)
        {
            _context.Book.Update(item);
        }
    }
}
