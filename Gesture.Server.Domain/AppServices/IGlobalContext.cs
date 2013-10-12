using Gestur.Core.Persistance.TransManager;

namespace Gestur.Server.App.AppServices
{
    /// <remarks>
    /// version 0.50 Chapter V: Service Locator
    /// version 0.71 Context Re-Factor 
    /// </remarks>
    public interface IGlobalContext
    {
        ITransFactory TransFactory { get; }        
    }
}
