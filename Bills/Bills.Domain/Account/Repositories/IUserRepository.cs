﻿using Bills.Domain.Account.Entities;
using System;

namespace Bills.Domain.Account.Repositories
{
    public interface IUserRepository
    {
        User Authenticate(string user);
        bool UserNameExists(string userName);
        User GetUserById(Guid id);
        void Register(User user);
        void Update(User user);
        void Remove(Guid id);

    }
}