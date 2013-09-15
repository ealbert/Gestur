using System;
using Gestur.Core.Message;
using Gestur.Core.Persistance.Repository;

namespace Gestur.Core.Persistance.TransManager
{
  public abstract class TransManagerBase
    : ITransManager
  {
    protected bool IsInTranx;

    protected IRepositoryLocator Locator { get; set; }

    #region ITransManager Members

    public TResult ExecuteCommand<TResult>(Func<IRepositoryLocator, TResult> command)
      where TResult : class, IDtoResponseEnvelop
    {
      try
      {
        BeginTransaction();
        var result = command.Invoke(Locator);
        CommitTransaction();
        CheckForWarnings(result);
        return result;
      }
      catch (BusinessException exception)
      {
        if (IsInTranx) Rollback();
        var type = typeof(TResult);
        var instance = Activator.CreateInstance(type, true) as IDtoResponseEnvelop;
        if (instance != null) instance.Response.AddBusinessException(exception);
        return instance as TResult;
      }
      catch (Exception e)
      {
        throw;
      }
    }

    public virtual void BeginTransaction()
    {
      IsInTranx = true;
      return;
    }

    public virtual void CommitTransaction()
    {
      IsInTranx = false;
      return;
    }

    public virtual void Rollback()
    {
      IsInTranx = false;
      return;
    }

    #endregion
    #region IDisposable Members

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    protected bool IsDisposed = false;

    protected virtual void Dispose(bool disposing)
    {
      if (!disposing) return;
      // free managed resources
      if (!IsDisposed && IsInTranx)
      {
        Rollback();
      }
      Locator = null;
      IsDisposed = true;
    }

    #endregion
    #region Abstract Methods -- Need Implementation

    protected abstract void CheckForWarnings<TResult>(TResult result);

    #endregion
  }
}