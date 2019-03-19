using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain
{
    public interface ILogger
    {
        void Debug(string messageTemplate, params object[] propertyValues);

        void Error(Exception exception, string messageTemplate);

        void Fatal(Exception exception, string messageTemplate);

        void Information<T>(string messageTemplate, T propertyValue);

        void Verbose<T>(string messageTemplate, T propertyValue);

        void Warning<T>(string messageTemplate, T propertyValue);
    }
}
