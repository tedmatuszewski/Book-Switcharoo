using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Types
{
    public abstract class Query<T> : Process
    {
        public T Result { get; protected set; }

        public override string ToString()
        {
            return "Query";
        }
    }
}
