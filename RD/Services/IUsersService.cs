﻿using RD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Services
{
    public interface IUsersService
    {
        public IEnumerable<User> GetUsers();

        public void AddUser(User user);

        public void UpdateUser(User user);

        public void DeleteUser(Guid id);
    }
}
