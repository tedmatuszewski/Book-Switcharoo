using BS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IMessageRepository messageRepository { get; }

        IThreadRepository threadRepository { get; }

        IBookRepository bookRepository { get; }

        IUserRepository userRepository { get; }

        void Save();

        void SaveAsync();
    }
}
