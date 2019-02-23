using BS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Repositories
{
    public interface IThreadRepository
    {
        IEnumerable<Thread> Get(string user);

        Thread Create(Thread thread);
    }
}
