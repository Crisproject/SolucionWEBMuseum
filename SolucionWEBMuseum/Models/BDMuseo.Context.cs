﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolucionWEBMuseum.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PruebaMuseoEntities : DbContext
    {
        public PruebaMuseoEntities()
            : base("name=PruebaMuseoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ARTISTA> ARTISTA { get; set; }
        public virtual DbSet<CONTENIDO> CONTENIDO { get; set; }
        public virtual DbSet<ESTADO> ESTADO { get; set; }
        public virtual DbSet<EVENTO> EVENTO { get; set; }
        public virtual DbSet<EXPOSICION> EXPOSICION { get; set; }
        public virtual DbSet<EXPOSICION_CONTENIDO> EXPOSICION_CONTENIDO { get; set; }
        public virtual DbSet<GENERO> GENERO { get; set; }
        public virtual DbSet<NOTICIA> NOTICIA { get; set; }
        public virtual DbSet<SOLICITUD> SOLICITUD { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}