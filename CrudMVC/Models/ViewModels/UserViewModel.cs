using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models.ViewModels
{

    public class EditUserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre de Usuario es requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El Email es requerido")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "La edad del Usuario es requerida")]
        public int Edad { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "La contrase;a es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contrase;as no coinciden")]
        public string ConfirmPassword { get; set; }
    }
    public class UserViewModel
    {

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre de Usuario es requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El Email es requerido")]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Display(Name ="Edad")]
        [Required(ErrorMessage = "La edad del Usuario es requerida")]
        public int Edad { get; set; }

        [Display(Name="Password")]
        [Required(ErrorMessage = "La contrase;a es requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="ConfirmPassword")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Las contrase;as no coinciden")]
        public string ConfirmPassword { get; set; }

        public string UserMessageError { get; set; }
    }
}