﻿using Bills.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Bills.Domain.Queries
{
    public static class UserQueries
    {
        public static Expression<Func<User, bool>> UserNameExists(string userName)
        {
            return x => x.UserName == userName;
        }

        public static Expression<Func<User, bool>> GetUserById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}