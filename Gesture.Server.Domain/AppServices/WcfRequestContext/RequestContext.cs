using System.ServiceModel;

namespace Gestur.Server.Domain.AppServices.WcfRequestContext
{
    public class RequestContext
        : IRequestContext
    {
        public IBusinessNotifier Notifier
        {
            get
            {
                var ic = OperationContext.Current.InstanceContext;
                var extension = ic.Extensions.Find<InstanceCreationExtension>();
                return extension.Notifier;
            }
        }
    }
}
