using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Request
{
    [DataContract]
    public class EmployeeRequest:BaseRequest
    {
        [DataMember]
        public int EmployeeId { get; set; }
    }
}
