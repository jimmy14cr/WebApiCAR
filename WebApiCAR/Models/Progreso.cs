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
    
    public partial class Progreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Progreso()
        {
            this.CursosMatriculados = new HashSet<CursosMatriculados>();
        }
    
        public int IdProgreso { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdModulo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CursosMatriculados> CursosMatriculados { get; set; }
    }
}
