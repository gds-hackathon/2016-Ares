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

    // Employee
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Employee
    {
        public int EmployeeId { get; set; } // EmployeeID (Primary key)
        public string EmployeeName { get; set; } // EmployeeName (length: 500)
        public bool Isactive { get; set; } // Isactive
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public int BalanceTypeId { get; set; } // BalanceTypeID
        public int UserId { get; set; } // UserID
        public System.DateTime ChangedDate { get; set; } // ChangedDate

        public Employee()
        {
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>