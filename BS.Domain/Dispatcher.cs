
//using Microsoft.Extensions.Logging;

//using Serilog;
//using Serilog.Events;

namespace BS.Domain
{
    public class Dispatcher : IDispatcher
    {
        private IUnitOfWork _unitOfWork;
        private ILogger _logger;

        public Dispatcher(IUnitOfWork work, ILogger logger)
        {
            _unitOfWork = work;
            _logger = logger;
        }

        public T Process<T>(T message) where T : Types.Process
        {
            message.Execute(_unitOfWork);

            var log = $"Executed {@message} of type  {message.GetType().Name}";

            _logger.Debug(log, message);

            return message;
        }
    }
}
