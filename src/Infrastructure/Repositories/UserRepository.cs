using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AmDomain.Models;
using AmDomain.Repositories;
namespace AmInfrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public void Delete(User item)
        {
            throw new NotImplementedException();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
