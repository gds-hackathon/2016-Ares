using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Request
{
    [DataContract]
    public class LoginRequest : BaseRequest
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
