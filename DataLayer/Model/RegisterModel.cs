using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class RegisterModel
    {
        [Display(Name = "Enter Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email not specified")]
        public string Email { get; set; }

        [Display(Name = "Enter Password")]
        [Required(ErrorMessage = "Password not specified")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Enter confirmation password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password entered incorrectly")]
        public string ConfirmPassword { get; set; }
    }
}
