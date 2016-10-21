using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Core.Domain
{
    public class TransactionRating: IAggregateRoot
    {
        public int TransactionId { get; set; } // TransactionID (Primary key)
        public short? RateLevel { get; set; } // RateLevel
        public string FeedBack { get; set; } // FeedBack (length: 500)
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.DateTime ChangedDate { get; set; } // ChangedDate

        public TransactionRating()
        {
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }
}
