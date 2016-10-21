using System;
using System.Runtime;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Ares.Contract.Response
{
    [DataContract]
    public class BaseResponse
    {
        public BaseResponse()
        {
            this.ResponseDate = DateTime.Now;
        }

        [DataMember]
        public DateTime ResponseDate { get; set; }

        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string ResponseMessage { get; set; }
    }
}
