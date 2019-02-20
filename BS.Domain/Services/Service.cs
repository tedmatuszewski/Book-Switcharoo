using BS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Services
{
    public partial class Service : IService
    {
        private readonly IBookRepository _bookRepository;

        public Service()
        {
        }

        public Service(IBookRepository bookRepository
        )
        {
            _bookRepository = bookRepository;
        }
    }
}
