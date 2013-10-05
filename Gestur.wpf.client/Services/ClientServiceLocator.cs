using System;
using Gestur.Core.Message;

namespace Gestur.wpf.client.Services
{
    /// <remarks>
    /// version 0.07 Chapter VII: Contract Locator
    /// version 0.10 Chapter X:   Dependency Injection
    /// version 0.14 Chapter XIV: Business Exception & Warnings
    /// </remarks>
    public class ClientServiceLocator
    {
        static readonly Object LocatorLock = new object();
        private static ClientServiceLocator _internalInstance;

        private ClientServiceLocator() { }

        public static ClientServiceLocator Instance()
        {
            if (_internalInstance == null)
            {
                lock (LocatorLock)
                {
                    // in case of a race scenario ... check again
                    if (_internalInstance == null)
                    {
                        _internalInstance = new ClientServiceLocator();
                    }
                }
            }
            return _internalInstance;
        }

        #region IClientServices Members

        public IBusinessExceptionManager ExceptionManager { get; set; }
        public IBusinessWarningManager WarningManager { get; set; }
        public ICommandDispatcher CommandDispatcher { get; set; }

        #endregion

    }
}
