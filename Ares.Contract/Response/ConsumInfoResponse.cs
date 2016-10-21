using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;


namespace Ares.Contract.Response
{
    [DataContract]
    public class ConsumInfoResponse : BaseResponse
    {
        [DataMember]
        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

        [DataMember]
        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

    }

    [DataContract]
    public class ResultSetModel1
    {
        [DataMember]
        public System.String CustomerName { get; set; }
        [DataMember]
        public System.Int32 CustomerID { get; set; }

        [DataMember]
        public System.Int32? TransCount { get; set; }

        [DataMember]
        public System.Decimal? TotalAmount { get; set; }

        [DataMember]
        public System.Decimal? DiscountAmount { get; set; }
    }


    [DataContract]
    public class ResultSetModel2
    {
        [DataMember]
        public System.Decimal? CurrentBalance { get; set; }
        [DataMember]
        public System.Decimal? TotalAmount { get; set; }
        [DataMember]
        public System.Decimal? DiscountAmount { get; set; }

        [DataMember]
        public System.Int32? TransCount { get; set; }
    }

}
