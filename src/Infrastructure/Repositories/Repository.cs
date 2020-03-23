using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AmDomain.Models;
using AmDomain.Repositories;
using System.Threading.Tasks;
using System.Linq;

namespace AmInfrastructure.Repositories
{
    public class Repository<T> where T : Entity
    {
        protected AmContext _db;
        protected DbSet<T> _dbSet;

        public Repository(AmContext context)
        {
            _db = context;
        }

        public virtual void Add(T item)
        {
            _dbSet.Add(item);
        }

        public virtual void Delete(T item)
        {
            _dbSet.Remove(item);
        }

        public virtual T FindById(int id)
        {
            var item = _dbSet.Find(id);
            return item;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void Update(T item)
        {
            _dbSet.Update(item);
        }

        public virtual int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public virtual Task<int> SaveChangesAsync()
        {
            return _db.SaveChangesAsync();
        }
    }
}
