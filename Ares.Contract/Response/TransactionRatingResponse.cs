using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Response
{
    [DataContract]
    public class TransactionRatingResponse
    {
        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public string EmployeeName { get; set; }

        [DataMember]
        public string Comment { get; set; }

        [DataMember]
        public int Score { get; set; }
    }
}
