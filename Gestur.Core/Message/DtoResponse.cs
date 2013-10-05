using System.Runtime.Serialization;

namespace Gestur.Core.Message
{
    /// <remarks>
    /// version 0.3 Chapter III: The Response
    /// </remarks>
    [DataContract]
    public sealed class DtoResponse
        : IDtoResponseEnvelop
    {
        public DtoResponse() : this(0) { }

        public DtoResponse(long entityId)
        {
            _responseInstance = new Response(entityId);
        }     

        [DataMember]
        private readonly Response _responseInstance;
        
        public Response Response
        {
            get { return _responseInstance; }
        }
    }
}
