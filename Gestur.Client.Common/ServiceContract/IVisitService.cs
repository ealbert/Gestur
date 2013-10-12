using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Gestur.Client.Common.Dto;

namespace Gestur.Client.Common.ServiceContract
{
  [ServiceContract]
  public interface IVisitService
  {
    [OperationContract]
    GetVisitsResponse GetVisits(CarerDto carer, DateTime dateTime);
  }
}
