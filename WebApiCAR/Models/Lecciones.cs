//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiCAR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lecciones
    {
        public int IdLeccion { get; set; }
        public Nullable<int> IdModulo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdTipoLeccion { get; set; }
    
        public virtual Modulos Modulos { get; set; }
        public virtual TipoLeccion TipoLeccion { get; set; }
    }
}