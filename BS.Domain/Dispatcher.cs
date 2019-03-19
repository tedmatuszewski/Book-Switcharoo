
namespace BS.Domain
{
    public class Dispatcher : IDispatcher
    {
        private IUnitOfWork _unitOfWork;
        //private ILogger<Dispatcher> _logger;
        //private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public Dispatcher(IUnitOfWork work)//, ILogger<Dispatcher> logger
        {
            _unitOfWork = work;
            //_logger = logger;
        }

        public T Process<T>(T query) where T : Types.Process
        {
            query.Execute(_unitOfWork);

            //_logger.LogInformation("");

            return query;
        }
    }
}
