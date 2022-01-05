using System;
using System.Collections.Generic;

//要加才能使用[Display(Name = "帳號")]
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class LoginViewModel
    {
        [Display(Name = "帳號")]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "密碼")]
        [Required]
        public string Password { get; set; }
    }
}
