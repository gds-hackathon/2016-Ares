using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Response
{
    [DataContract]
    public class CalculateDiscountResponse : BaseResponse
    {
        [DataMember]
        public decimal RealPay { get; set; }
    }
}
