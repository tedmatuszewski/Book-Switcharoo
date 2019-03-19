
using Microsoft.Extensions.Logging;

namespace BS.Domain
{
    public class Dispatcher : IDispatcher
    {
        private IUnitOfWork _unitOfWork;
        private ILogger<Dispatcher> _logger;
        //private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public Dispatcher(IUnitOfWork work, ILogger<Dispatcher> logger)//
        {
            _unitOfWork = work;
            _logger = logger;
        }

        public T Process<T>(T message) where T : Types.Process
        {
            message.Execute(_unitOfWork);

            _logger.LogTrace("Processed {@message} retrieved from cache", message);

            return message;
        }
    }
}
