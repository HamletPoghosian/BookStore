using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "No Email specified")]
        public string Email { get; set; }

        [Required(ErrorMessage = "No Password specified")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Invalid password")]
        public string ConfirmPassword { get; set; }
    }
}
