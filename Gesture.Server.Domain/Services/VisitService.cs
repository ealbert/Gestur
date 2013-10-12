using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Gestur.Client.Common.Dto;
using Gestur.Client.Common.ServiceContract;
using Gestur.Core.Persistance.Repository;
using Gestur.Server.App.AppServices.WcfRequestContext;

namespace Gestur.Server.App.Services
{
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
  [InstanceCreation]
  public class VisitService : ServiceBase, IVisitService
  {
    public GetVisitsResponse GetVisits(CarerDto carer, DateTime dateTime)
    {
      return ExecuteCommand(locator => GetVisitsImplementation(locator, carer, dateTime));
    }

    private GetVisitsResponse GetVisitsImplementation(IRepositoryLocator locator, CarerDto carer, DateTime dateTime)
    {
      throw new NotImplementedException();
    }
  }
}
