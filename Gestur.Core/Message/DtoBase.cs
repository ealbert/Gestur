using System.Runtime.Serialization;

namespace Gestur.Core.Message
{
    /// <remarks>
    /// version 0.3 Chapter III: The Response
    /// </remarks>
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
