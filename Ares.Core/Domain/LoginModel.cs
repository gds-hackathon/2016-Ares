using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares.Core.Domain
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        [Display(Name = "RememberMe")]
        public bool RememberMe { get; set; }
    }
}
