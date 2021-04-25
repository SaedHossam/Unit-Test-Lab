using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Contracts;

namespace Repository
{
    class RoleRepository : RepositoryBase<Roles>, IRoleRepository
    {
        public RoleRepository(DB_Context context) : base(context)
        {
        }
    }
}
