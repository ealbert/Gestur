using System.Collections.Generic;
using System.Linq;
using Gestur.Core.Message;

namespace Gestur.Server.Domain.AppServices
{
    /// <remarks>
    /// version 0.5 Chapter V: Service Locator
    /// </remarks>
    public class BusinessNotifier
        : IBusinessNotifier
    {
        private readonly IList<BusinessWarning> _warningList = new List<BusinessWarning>();

        #region Implementation of IBusinessNotifier

        public void AddWarning(BusinessWarningEnum warningType, string message)
        {
            _warningList.Add(new BusinessWarning(warningType, message));
        }

        public bool HasWarnings
        {
            get { return _warningList.Count > 0; }
        }

        public IEnumerable<BusinessWarning> RetrieveWarnings()
        {
            if (!HasWarnings) return null;
            var results = _warningList.ToList();
            _warningList.Clear();
            return results;
        }

        #endregion
    }
}
