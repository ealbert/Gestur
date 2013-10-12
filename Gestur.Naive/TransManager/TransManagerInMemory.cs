using Gestur.Core.Message;
using Gestur.Core.Persistance.TransManager;
using Gestur.Naive.Repository;
using Gestur.Server.App.AppServices;

namespace Gestur.Naive.TransManager
{
    /// <remarks>
    /// version 0.04 Chapter IV: Transaction Manager
    /// version 0.10 Chapter X: Renamed from TransManagerEntityStore to TransManagerInMemory
    /// </remarks>
    public class TransManagerInMemory
        : TransManagerBase
    {
        public TransManagerInMemory()
        {
            Locator = new RepositoryLocatorInMemory();
        }

        #region Overrides of TransManager

        /// <summary>
        /// Need to override this method because
        /// we want to keep the transmanager in the
        /// Entity Store implementation as instances
        /// are stored in memory
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (!disposing) return;
            // free managed resources
            if (!IsDisposed && IsInTranx)
            {
                Rollback();
            }
            //Locator = null;
            IsDisposed = true;
        }

      protected override void CheckForWarnings<TResult>(TResult result)
      {
        var response = result as IDtoResponseEnvelop;
        if (response == null) return;
        var notifier = Container.RequestContext.Notifier;
        if (notifier.HasWarnings) response.Response.AddBusinessWarnings(notifier.RetrieveWarnings());
      }

      #endregion
    }
}
