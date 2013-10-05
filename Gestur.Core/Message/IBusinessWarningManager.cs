using System.Collections.Generic;

namespace Gestur.Core.Message
{
    public interface IBusinessWarningManager
    {
        void HandleBusinessWarning(IEnumerable<BusinessWarning> warnings);
    }
}
