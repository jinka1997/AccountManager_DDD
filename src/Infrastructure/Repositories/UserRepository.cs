using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AmDomain.Models;
using AmDomain.Repositories;
namespace AmInfrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AmContext context)
            :base(context)
        {
        }
    }
}
