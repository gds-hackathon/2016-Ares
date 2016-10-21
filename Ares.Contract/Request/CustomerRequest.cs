using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Request
{
    [DataContract]
    public class CustomerRequest:BaseRequest
    {
        [DataMember]
        public int CustomerId { get; set; }

    }
}
