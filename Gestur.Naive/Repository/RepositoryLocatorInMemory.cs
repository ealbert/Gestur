using System;
using System.Collections.Generic;
using Gestur.Core.Persistance.Repository;

namespace Gestur.Naive.Repository
{
    public class RepositoryLocatorInMemory
        : RepositoryLocatorBase, IResetable
    {
        protected override IRepository<T> CreateRepository<T>()
        {
            return new RepositoryInMemory<T>();
        }

        public void Reset()
        {
            RepositoryMap = new Dictionary<Type, object>();
        }
    }
}
