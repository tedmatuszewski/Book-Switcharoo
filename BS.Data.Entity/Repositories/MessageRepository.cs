using BS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Data.Entity.Repositories
{
    public class MessageRepository : Domain.Repositories.IMessageRepository
    {
        readonly BookSwapContext _context;

        public MessageRepository(BookSwapContext context)
        {
            _context = context;
        }

        public IEnumerable<Message> GetByThread(int threadId)
        {
            var messages = _context.Message.Include(m => m.Thread).Where(m => m.ThreadId == threadId).AsEnumerable();

            return messages;
        }

        public Message Get(int id)
        {
            var message = _context.Message.Include(m => m.Thread).SingleOrDefault(m => m.Id == id);

            return message;
        }

        public Message Create(Message message)
        {
            var result = _context.Message.Add(message);

            result.State = EntityState.Added;

            return result.Entity;
        }
    }
}
