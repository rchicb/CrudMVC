//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int IdUser { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int edad { get; set; }
        public int idState { get; set; }
    
        public virtual State State { get; set; }
    }
}
