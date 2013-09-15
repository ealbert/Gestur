using System;
using Gestur.Core.Message;
using Gestur.Core.Persistance.Repository;

namespace Gestur.Core.Persistance.TransManager
{
  public interface ITransManager
    : IDisposable
  {
    TResult ExecuteCommand<TResult>(Func<IRepositoryLocator, TResult> command)
      where TResult : class, IDtoResponseEnvelop;

    void BeginTransaction();
    void CommitTransaction();
    void Rollback();
  }
}