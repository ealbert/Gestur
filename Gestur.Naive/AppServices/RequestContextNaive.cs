using Gestur.Server.App.AppServices;

namespace Gestur.Naive.AppServices
{
    public class RequestContextNaive
        :IRequestContext
    {
        private BusinessNotifier _businessNotifierInstance;

        public IBusinessNotifier Notifier
        {
            get 
            {
                if (_businessNotifierInstance != null) return _businessNotifierInstance;
                _businessNotifierInstance = new BusinessNotifier();
                return _businessNotifierInstance;
            }
        }
    }
}
