//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Finanzas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CategoriaPersona
    {
        public CategoriaPersona()
        {
            this.Persona = new HashSet<Persona>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Categoria de Persona")]
        [Remote("CheckCategoria", "CategoriaPersona", AdditionalFields = "id", ErrorMessage = "Ya existe este Categoria de Persona")]
        public string categoria { get; set; }
    
        public virtual ICollection<Persona> Persona { get; set; }

        public override string ToString()
        {
            return categoria;
        }
    }
}
