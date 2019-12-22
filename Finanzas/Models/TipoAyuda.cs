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
    
    public partial class TipoAyuda
    {
        public TipoAyuda()
        {
            this.SalidaAlmacen = new HashSet<SalidaAlmacen>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Tipo Ayuda")]
        [Remote("CheckTipoAyuda", "TipoAyuda", AdditionalFields = "id", ErrorMessage = "Ya existe este usuario")]
        public string tipo { get; set; }

        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }
    
        public virtual ICollection<SalidaAlmacen> SalidaAlmacen { get; set; }

        public override string ToString()
        {
            return tipo;
        }
    }
}
