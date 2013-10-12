using System;
using Gestur.Core.Message;
using Gestur.Core.Persistance.Repository;
using Gestur.Core.Persistance.TransManager;
using Gestur.Server.App.AppServices;

namespace Gestur.Server.App.Services
{
  public class ServiceBase
  {
    protected TResult ExecuteCommand<TResult>(Func<IRepositoryLocator, TResult> command)
      where TResult : class, IDtoResponseEnvelop
    {
      using (ITransManager manager = Container.GlobalContext.TransFactory.CreateManager())
      {
        return manager.ExecuteCommand(command);
      }
    }
  }
}