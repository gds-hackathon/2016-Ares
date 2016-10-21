using System.Runtime;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Response
{
    [DataContract]
    public class LoginResponse : BaseResponse
    {
        public string NickName { get; set; }

        public decimal Balance { get; set; }

        public int Count { get; set; }



    }
}
