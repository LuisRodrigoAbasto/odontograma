﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbodontogramaEntity : DbContext
    {
        public dbodontogramaEntity()
            : base("name=dbodontogramaEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<atencion> atencion { get; set; }
        public virtual DbSet<atencion_detalle> atencion_detalle { get; set; }
        public virtual DbSet<diente> diente { get; set; }
        public virtual DbSet<odontograma> odontograma { get; set; }
        public virtual DbSet<odontograma_detalle> odontograma_detalle { get; set; }
        public virtual DbSet<paciente> paciente { get; set; }
        public virtual DbSet<parte> parte { get; set; }
        public virtual DbSet<tratamiento> tratamiento { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}