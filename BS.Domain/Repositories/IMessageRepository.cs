using BS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Repositories
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetByThread(int threadId);

        Message Get(int id);

        Message Create(Message message);
    }
}
