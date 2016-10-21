using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Core.Domain
{
    public class TransactionModel
    {
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; } // EmployeeID (Primary key)

        [Display(Name = "Transaction Date")]
        public DateTime TransactionDateTime { get; set; }

        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; } // TotalAmount

        [Display(Name = "Discount Amount")]
        public decimal DiscountAmount { get; set; } // DiscountAmount

        [Display(Name = "Order Id")]
        public int? OrderId { get; set; } // OrderID

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; } // CustomerName (length: 500)

        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; } // EmployeeName (length: 500)

        public static explicit operator TransactionModel(Transaction v)
        {
            throw new NotImplementedException();
        }
    }
}
