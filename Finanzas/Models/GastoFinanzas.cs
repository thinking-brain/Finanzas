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
    
    public partial class GastoFinanzas
    {
        public int id { get; set; }
        public int Cuentasid { get; set; }
        public int ConceptoGastoid { get; set; }
        public Nullable<int> SubconceptoGastoid { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [Remote("CheckFecha", "GastoFinanza", ErrorMessage = "La fecha no corresponde al mes y a�o actual del sistema")]
        public System.DateTime fecha { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Importe")]
        [DataType(DataType.Currency)]
        [Remote("CheckImporte", "GastoFinanza", AdditionalFields = "id,Cuentasid", ErrorMessage = "La cuenta especificada no tiene saldo para hacer este gasto", HttpMethod = "POST")]
        public decimal importe { get; set; }

        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }

        public int Usuarioid { get; set; }
    
        public virtual ConceptoGasto ConceptoGasto { get; set; }
        public virtual Cuentas Cuentas { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual SubconceptoGasto SubconceptoGasto { get; set; }
    }
}