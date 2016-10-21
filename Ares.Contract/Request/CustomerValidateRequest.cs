using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Request
{
    [DataContract]
    public class CustomerValidateRequest : BaseRequest
    {
        [DataMember]
        public string QRCode { get; set; }
    }
}
