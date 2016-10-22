using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Core.Domain
{
    public class RegistryModel
    {
        [DisplayName("Login Name")]
        public string LoginName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNum { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Role Type")]
        public string RoleType { get; set; }
    }
}
