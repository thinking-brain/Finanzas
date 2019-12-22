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
    
    public partial class Persona
    {
        public Persona()
        {
            this.IngresoFinanzas = new HashSet<IngresoFinanzas>();
            this.MisionesAtendidas = new HashSet<Misiones>();
        }
    
        public int id { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "CI")]
        [RegularExpression(@"\d{11}", ErrorMessage = "Deben ser 11 Digitos")]
        [Remote("CheckCI", "Persona", AdditionalFields = "id", ErrorMessage = "Ya existe esta persona (Puede que este inactiva)")]
        [ValidarCi]
        public string ci { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Primer Apellido")]
        public string apellido1 { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string apellido2 { get; set; }

        [Required(ErrorMessage = "Este dato es Obligatorio")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [Remote("CheckFechaNacimiento", "Persona", ErrorMessage = "La fecha de nacimiento no puede ser mayor al mes y a�o actual del sistema")]
        public System.DateTime fechaNacimiento { get; set; }

        [Display(Name = "Miembro")]
        public bool miembro { get; set; }

        [Display(Name = "Fecha de Conversion")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> fechaConversion { get; set; }

        [Display(Name = "Fecha de Bautismo")]
        [DataType(DataType.Date)]
        [FechaMayorQue("fechaConversion")]
        public Nullable<System.DateTime> fechaBautismo { get; set; }

        public int CategoriaPersonaid { get; set; }
        public Nullable<int> Misionesid { get; set; }

        [Display(Name = "Activo")]
        public bool activo { get; set; }
    
        public virtual CategoriaPersona CategoriaPersona { get; set; }
        public virtual ICollection<IngresoFinanzas> IngresoFinanzas { get; set; }
        public virtual ICollection<Misiones> MisionesAtendidas { get; set; }
        public virtual Misiones MisionPertenece { get; set; }

        public override string ToString()
        {
            var persona = nombre;
            if (apellido1 != null)
            {
                persona += " " + apellido1;
            }
            if (apellido2 != null)
            {
                persona += " " + apellido2;
            }
            return persona;
        }

        public string sexo
        {
            get
            {
                var s = int.Parse(ci.Substring(9, 1));
                var sexo = "M";
                if (s % 2 == 1)
                {
                    sexo = "F";
                }
                return sexo;
            }
        }

        //[DataType(DataType.Date)]
        //public DateTime fechaNacimiento
        //{
        //    get
        //    {
        //        var anno = int.Parse(ci.Substring(0, 2));
        //        var mes = int.Parse(ci.Substring(2, 2));
        //        var dia = int.Parse(ci.Substring(4, 2));
        //        try
        //        {
        //            DateTime fechaN = new DateTime(anno, mes, dia);
        //            return fechaN;
        //        }
        //        catch (Exception)
        //        {

        //        }
        //        return new DateTime();
        //    }
        //}
    }
}
