﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Roles
    {
        public int Id { get; set; }

        public string Role { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}
