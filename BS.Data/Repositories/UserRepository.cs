using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BS.Domain.Entities;
using BS.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BS.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly BookSwapContext _context;

        public UserRepository(BookSwapContext context)
        {
            _context = context;
        }

        public User Create(User entity)
        {
            var result = _context.User.Add(entity);

            result.State = EntityState.Added;

            return result.Entity;
        }

        public User Delete(int id)
        {
            var result = _context.User.Find(id);

            result.IsDeleted = true;
            _context.Entry(result).State = EntityState.Modified;

            return result;
        }

        public User Get(int id)
        {
            var entity = this._context.User.AsNoTracking().SingleOrDefault(u => u.IsDeleted == false && u.Id == id);

            return entity;
        }

        public IEnumerable<User> Get()
        {
            var entities = this._context.User.AsNoTracking().Where(u => u.IsDeleted == false).AsEnumerable();

            return entities;
        }

        public User Update(User entity)
        {
            var user = _context.Attach(entity);

            user.State = EntityState.Modified;

            return user.Entity;
        }
    }
}
