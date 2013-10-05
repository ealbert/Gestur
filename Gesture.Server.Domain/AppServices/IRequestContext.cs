namespace Gestur.Server.Domain.AppServices
{
    public interface IRequestContext
    {
        IBusinessNotifier Notifier { get; }
    }
}
