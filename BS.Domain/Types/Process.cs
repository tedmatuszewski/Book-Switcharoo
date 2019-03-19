using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Types
{
    public abstract class Process
    {
        public abstract void Execute(IUnitOfWork _unit);

        public abstract string Title { get; }

        public string Message { get; protected set; }

        public Guid OperationId = Guid.NewGuid();
    }
}
