//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDato
{
    using System;
    using System.Collections.Generic;
    
    public partial class atencion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public atencion()
        {
            this.atencion_detalle = new HashSet<atencion_detalle>();
        }
    
        public int atencionID { get; set; }
        public Nullable<int> pacienteID { get; set; }
        public Nullable<int> empleadoID { get; set; }
        public Nullable<int> odontologoID { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
        public Nullable<decimal> importe { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public Nullable<int> estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<atencion_detalle> atencion_detalle { get; set; }
        public virtual users empleado { get; set; }
        public virtual users odontologo { get; set; }
        public virtual paciente paciente { get; set; }
    }
}
