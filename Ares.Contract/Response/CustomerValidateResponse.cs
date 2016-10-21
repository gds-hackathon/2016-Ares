using System.ServiceModel;
using System.Runtime.Serialization;


namespace Ares.Contract.Response
{
    [DataContract]
    public class CustomerValidateResponse:BaseResponse
    {
        [DataMember]
        public bool IsValidate { get; set; }

        [DataMember]
        public int CustomerId { get; set; }
    }
}
