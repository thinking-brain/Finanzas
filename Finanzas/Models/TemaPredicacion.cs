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
    
    public partial class TemaPredicacion
    {
        public TemaPredicacion()
        {
            this.EscuelaDominical = new HashSet<EscuelaDominical>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Tema")]
        [Remote("CheckTema", "TemaPredicacion",AdditionalFields = "id",ErrorMessage = "Ya existe este tema")]
        public string tema { get; set; }
    
        public virtual ICollection<EscuelaDominical> EscuelaDominical { get; set; }
    }
}
