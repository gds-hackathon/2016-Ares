

namespace Ares.Core.Domain
{

    // UserRole
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class UserRole : IAggregateRoot
    {
        public int UserId { get; set; } // UserId (Primary key)
        public int RoleId { get; set; } // RoleID
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.DateTime ChangedDate { get; set; } // ChangedDate

        public UserRole()
        {
            CreatedDate = System.DateTime.Now;
            ChangedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
