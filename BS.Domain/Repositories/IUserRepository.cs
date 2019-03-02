using BS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Repositories
{
    public interface IUserRepository
    {
        User Create(User entity);

        User Update(User entity);

        User Delete(int id);

        User Get(int id);

        IEnumerable<User> Get();
    }
}