using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Response
{
    [DataContract]
    public class CustomerResponse:BaseResponse
    {
        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int Discount { get; set; }


    }
}
