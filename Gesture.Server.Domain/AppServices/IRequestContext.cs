namespace Gestur.Server.App.AppServices
{
    public interface IRequestContext
    {
        IBusinessNotifier Notifier { get; }
    }
}
