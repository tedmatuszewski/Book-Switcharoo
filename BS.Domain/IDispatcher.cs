using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain
{
    public interface IDispatcher
    {
        T Process<T>(T query) where T : Types.Process;
    }
}
