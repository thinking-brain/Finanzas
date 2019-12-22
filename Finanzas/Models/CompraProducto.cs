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
using Finanzas.Filters;

namespace Finanzas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompraProducto
    {
        public int id { get; set; }
        public int Cuentasid { get; set; }
        public int Productoid { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [Remote("CheckFecha","CompraProducto",ErrorMessage = "La fecha no corresponde al mes y a�o actual del sistema")]
        public System.DateTime fecha { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Cantidad")]
        [Range(0, int.MaxValue)]
        public int cantidad { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Importe Total de la Compra")]
        [DataType(DataType.Currency)]
        [Remote("CheckSaldo", "CompraProducto", AdditionalFields = "Cuentasid", ErrorMessage = "La cuenta no tiene saldo para realizar esta compra")]
        public decimal importe { get; set; }

        public int Usuarioid { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Cuentas Cuentas { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}