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
    
    public partial class paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public paciente()
        {
            this.atencion = new HashSet<atencion>();
        }
    
        public int pacienteID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ci { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string sexo { get; set; }
        public Nullable<int> estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<atencion> atencion { get; set; }
    }
}
