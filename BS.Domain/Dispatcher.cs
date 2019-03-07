using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain
{
    public class Dispatcher : IDispatcher
    {
        private IUnitOfWork _unitOfWork;

        public Dispatcher(IUnitOfWork work)
        {
            _unitOfWork = work;
        }

        public T Process<T>(T query) where T : Types.Process
        {
            query.Execute(_unitOfWork);

            return query;
        }
    }
}
