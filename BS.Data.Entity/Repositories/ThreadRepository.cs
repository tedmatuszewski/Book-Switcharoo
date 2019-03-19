using BS.Domain.Entities;
using BS.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Data.Entity.Repositories
{
    public class ThreadRepository : IThreadRepository
    {
        readonly BookSwapContext _context;

        public ThreadRepository(BookSwapContext context)
        {
            _context = context;
        }

        public IEnumerable<Thread> Get(string user)
        {
            var threads = _context.Thread
                            .Include(t => t.Book)
                            .Include(t => t.Message)
                            .Where(m => m.From.ToLower().Trim() == user.Trim().ToLower() || m.To.ToLower().Trim() == user.Trim().ToLower())
                            .OrderByDescending(m => m.DateAdded)
                            .AsEnumerable();

            return threads;
        }

        public Thread Create(Thread thread)
        {
            var result = _context.Thread.Add(thread);

            result.State = EntityState.Added;

            return result.Entity;
        }
    }
}
