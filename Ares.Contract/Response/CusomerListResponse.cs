using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Response
{
    [DataContract]
    public class CusomerListResponse : BaseResponse
    {
        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public int Discount { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public System.Int32 CustomerID { get; set; }



    }
}
