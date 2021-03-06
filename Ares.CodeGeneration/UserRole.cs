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

    // UserRole
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class UserRole
    {
        public int UserId { get; set; } // UserId (Primary key)
        public int RoleId { get; set; } // RoleID
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.DateTime ChangedDate { get; set; } // ChangedDate
        public string UserName { get; set; } // UserName (length: 500)
        public string PhoneNum { get; set; } // PhoneNum (length: 50)
        public string Password { get; set; } // Password (length: 500)

        public UserRole()
        {
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
