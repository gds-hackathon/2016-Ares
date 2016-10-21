// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.61
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace Ares.CodeGeneration
{

    // TransactionRating
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class TransactionRating
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
// </auto-generated>
