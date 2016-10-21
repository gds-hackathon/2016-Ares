using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Request
{
    [DataContract]
    public class CalculateDiscountRequest:BaseRequest
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public decimal TotalAmount { get; set; }
    }
}
