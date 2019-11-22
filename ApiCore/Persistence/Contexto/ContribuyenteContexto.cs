using ApiCore.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Persistence.Contexto
{
    public class ContribuyenteContexto : DbContext
    {
        
        public ContribuyenteContexto(DbContextOptions<ContribuyenteContexto> options) : base(options)
        {
        }

        public virtual DbSet<ActividadEconomica> ActividadEconomica { get; set; }

        public virtual DbSet<Renta> Renta { get; set; }
        public virtual DbSet<Ruc> Ruc { get; set; }
        public virtual DbSet<RucCategoria> RucCategoria { get; set; }
        public virtual DbSet<RucCertificacion> RucCertificacion { get; set; }
        public virtual DbSet<RucCiiu> RucCiiu { get; set; }
        public virtual DbSet<RucEmbajador> RucEmbajador { get; set; }
        public virtual DbSet<RucEmpleador> RucEmpleador { get; set; }
        public virtual DbSet<RucInformacionFinanciera> RucInformacionFinanciera { get; set; }
        public virtual DbSet<RucInformacionSocio> RucInformacionSocio { get; set; }
        public virtual DbSet<RucJuntaDirectiva> RucJuntaDirectiva { get; set; }
        public virtual DbSet<RucJuridica> RucJuridica { get; set; }
        public virtual DbSet<RucNatural> RucNatural { get; set; }
        public virtual DbSet<RucObligacion> RucObligacion { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ruc>()
                       .HasOne(p => p.RucJuridica)
                       .WithOne(i => i.Ruc)
                       .HasForeignKey<RucJuridica>(b => b.IdNit);

            modelBuilder.Entity<Ruc>()
                       .HasOne(p => p.RucNatural)
                       .WithOne(i => i.Ruc)
                       .HasForeignKey<RucNatural>(b => b.IdNit);
           

        }
    }
}
