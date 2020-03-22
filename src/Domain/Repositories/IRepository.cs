using System;
using AmDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace AmDomain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        T FindById(int id);
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
