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

    // Administrator
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Administrator
    {
        public int AdminId { get; set; } // AdminID (Primary key)
        public string AdminName { get; set; } // AdminName (length: 500)
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public int UserId { get; set; } // UserID
        public System.DateTime ChangedDate { get; set; } // ChangedDate
        public bool Isactive { get; set; } // Isactive

        public Administrator()
        {
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
