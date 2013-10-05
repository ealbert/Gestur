using System;
using Gestur.Core.Persistance.TransManager;

namespace Gestur.Server.Domain.AppServices
{   
    public class GlobalContext
        : IGlobalContext
    {
        static readonly Object LocatorLock = new object();
        private static volatile GlobalContext _internalInstance;

        private GlobalContext() { }

        public static GlobalContext Instance()
        {
            if (_internalInstance == null)
            {
                lock (LocatorLock)
                {
                    // in case of a race scenario ... check again
                    if (_internalInstance == null)
                    {
                        _internalInstance = new GlobalContext();;
                    }
                }
            }
            return _internalInstance;
        }
    
        #region IGlobalContext Members

        public ITransFactory TransFactory { get; set; }

        #endregion
    }
}
