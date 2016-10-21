using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Core.Dto
{
    public class GetCustomerReturnModel
    {
        public System.String CustomerName { get; set; }
        public System.Int32? RateLevel { get; set; }
        public System.Int32 DiscountRating { get; set; }
        public System.String Address { get; set; }
    }
}
