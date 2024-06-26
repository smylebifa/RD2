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

        public void UpdateUser(User user);

        public void DeleteUser(int id);

        public bool ChangeLogin(string oldLogin, string newLogin);

        public void ChangePassword(string Login, string OldPassword, string NewPassword, string NewPassword2);

    }
}
