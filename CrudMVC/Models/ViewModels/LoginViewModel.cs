using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage ="El campo Email es obligatorio")]
        [StringLength(100,ErrorMessage ="El Email debe de contener al menos 1 caracter",MinimumLength =1)]
        public string Email { get; set; }

        [Required(ErrorMessage ="El campo Password es obligatorio")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string LoginMessageError { get; set; }
    }
}