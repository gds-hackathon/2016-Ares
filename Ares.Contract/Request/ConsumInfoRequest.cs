using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Request
{
    [DataContract]
    public class ConsumInfoRequest:BaseRequest
    {
        [DataMember]
        public int EmployeeId { get; set; }
    }
}
