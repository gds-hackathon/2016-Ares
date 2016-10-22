using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Request
{
    [DataContract]
    public class SubmitCommentRequest
    {
        [DataMember]
        public int Transactionid { get; set; }

        [DataMember]
        public short Score { get; set; }

        [DataMember]
        public string Comment { get; set; }
    }
}
