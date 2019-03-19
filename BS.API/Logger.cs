using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BS.API
{
    public class Logger : BS.Domain.ILogger
    {
        public void Debug(string messageTemplate, params object[] propertyValues)
        {
            Serilog.Log.Debug(messageTemplate, propertyValues);
        }

        public void Error(Exception exception, string messageTemplate)
        {
            Serilog.Log.Error(messageTemplate, messageTemplate);
        }
        
        public void Fatal(Exception exception, string messageTemplate)
        {
            Serilog.Log.Fatal(messageTemplate, messageTemplate);
        }
        
        public void Information<T>(string messageTemplate, T propertyValue)
        {
            Serilog.Log.Information(messageTemplate, propertyValue);
        }
        
        public void Verbose<T>(string messageTemplate, T propertyValue)
        {
            Serilog.Log.Verbose(messageTemplate, propertyValue);
        }
        
        public void Warning<T>(string messageTemplate, T propertyValue)
        {
            Serilog.Log.Warning(messageTemplate, propertyValue);
        }
    }
}