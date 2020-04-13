using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudMVC.Models.ViewModels
{
    public class FileViewModel
    {
        [Required(ErrorMessage ="El campo es obligatorio")]
        [DisplayName("Seleccione un Archivo")]
        public HttpPostedFileBase Archivo1 { get; set; }

        [Required(ErrorMessage ="El campo es obligatorio")]
        [DisplayName("Seleccione un Archivo")]
        public HttpPostedFileBase Archivo2 { get; set; }
        
        [Required(ErrorMessage ="Campo cadena Obligatorio")]
        [DisplayName("Agregar Cadena")]
        public string Cadena { get; set; }
    }
}