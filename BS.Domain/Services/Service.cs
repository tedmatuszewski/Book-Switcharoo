using BS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Services
{
    public partial class Service : IService
    {
        private IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork work)
        {
            _unitOfWork = work;
        }
    }
}
