using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Core.Dto
{
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class SettlementForCustomerReturnModel
    {
        [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
        public class ResultSetModel1
        {
            public System.Int32? TransYear { get; set; }
            public System.Int32? TransMonth { get; set; }
            public System.Decimal? TotalPay { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

        [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
        public class ResultSetModel2
        {
            public System.Int32? CustomerID { get; set; }
            public System.String CustomerName { get; set; }
            public System.Decimal? DiscountAmount { get; set; }
            public System.Int32? TransCount { get; set; }
            public System.Decimal? TotalAmount { get; set; }
            public System.Decimal? NeedPay { get; set; }
        }
        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

    }

}
// </auto-generated>
