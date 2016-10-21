using System.Runtime;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Response
{
    [DataContract]
    public class LoginResponse : BaseResponse
    {
        [DataMember]
        public string NickName { get; set; }

        [DataMember]
        public decimal Balance { get; set; }

        [DataMember]
        public int Count { get; set; }



    }
}
