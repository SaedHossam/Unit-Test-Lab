using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Repository
{
    class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DB_Context context) : base(context)
        {
        }
    }
}
