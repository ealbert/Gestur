using System.Runtime.Serialization;
using Gestur.Core.Message;

namespace Gestur.Client.Common.Message
{
  [DataContract]
  public abstract class DtoBase
    : IDtoResponseEnvelop
  {
    #region IDtoResponseEnvelop Members

    [DataMember]
    private readonly Response _responseInstance = new Response();
    public Response Response
    {
      get { return _responseInstance; }
    }

    #endregion
  }
}