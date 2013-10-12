using System.Collections.Generic;
using Gestur.Core.Message;

namespace Gestur.Server.App.AppServices
{
    /// <remarks>
    /// version 0.5 Chapter V: Service Locator
    /// </remarks>
    public interface IBusinessNotifier
    {
        void AddWarning(BusinessWarningEnum warningType, string message);
        bool HasWarnings { get; }
        IEnumerable<BusinessWarning> RetrieveWarnings();
    }
}
