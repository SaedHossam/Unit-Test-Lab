using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Models;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        public DB_Context _db { get; set; }
        private UserRepository _user;

        private RoleRepository _role;

        public RepositoryWrapper(DB_Context db)
        {
            _db = db;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_db);
                }

                return _user;
            }
        }

        public IRoleRepository Role
        {
            get
            {
                if(_role == null)
                {
                    _role = new RoleRepository(_db);
                }

                return _role;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
