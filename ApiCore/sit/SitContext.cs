using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiCore.sit
{
    public partial class SitContext : DbContext
    {
        public SitContext()
        {
        }

        public SitContext(DbContextOptions<SitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Controlenvios> Controlenvios { get; set; }
        public virtual DbSet<Retenciones> Retenciones { get; set; }
        public virtual DbSet<Retenedores> Retenedores { get; set; }
        public virtual DbSet<TipoCambios> TipoCambios { get; set; }
        public virtual DbSet<Traslados> Traslados { get; set; }

        // Unable to generate entity type for table 'bk1_retenciones'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=10.16.216.134;User Id=mmartinez;Password=desar2015*;Database=ret_tarjetas");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.ToTable("bitacora");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaYhora)
                    .HasColumnName("fechaYHora")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Controlenvios>(entity =>
            {
                entity.ToTable("controlenvios");

                entity.HasIndex(e => e.Idretenedor)
                    .HasName("FK_controlenvios_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Fechaenviada)
                    .HasColumnName("fechaenviada")
                    .HasColumnType("date");

                entity.Property(e => e.Idretenedor)
                    .HasColumnName("idretenedor")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.IdretenedorNavigation)
                    .WithMany(p => p.Controlenvios)
                    .HasForeignKey(d => d.Idretenedor)
                    .HasConstraintName("FK_controlenvios_1");
            });

            modelBuilder.Entity<Retenciones>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PRIMARY");

                entity.ToTable("retenciones");

                entity.HasIndex(e => e.Fecharetencion)
                    .HasName("Index_4");

                entity.HasIndex(e => e.Periodo)
                    .HasName("Index_5");

                entity.HasIndex(e => e.Rucretenedor)
                    .HasName("rucretenedoridx");

                entity.HasIndex(e => e.Rucretenido)
                    .HasName("rucretenido");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fechafinaltransaccion)
                    .HasColumnName("fechafinaltransaccion")
                    .HasColumnType("date");

                entity.Property(e => e.Fechainicialtransaccion)
                    .HasColumnName("fechainicialtransaccion")
                    .HasColumnType("date");

                entity.Property(e => e.Fechapago)
                    .HasColumnName("fechapago")
                    .HasColumnType("date");

                entity.Property(e => e.Fecharecepcion)
                    .HasColumnName("fecharecepcion")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Fecharetencion)
                    .HasColumnName("fecharetencion")
                    .HasColumnType("date");

                entity.Property(e => e.Montocomision)
                    .HasColumnName("montocomision")
                    .HasColumnType("decimal(11,2) unsigned");

                entity.Property(e => e.Montoretenido)
                    .HasColumnName("montoretenido")
                    .HasColumnType("decimal(11,2) unsigned");

                entity.Property(e => e.Montototal)
                    .HasColumnName("montototal")
                    .HasColumnType("decimal(11,2) unsigned");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasColumnName("periodo")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rucretenedor)
                    .IsRequired()
                    .HasColumnName("rucretenedor")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.Rucretenido)
                    .HasColumnName("rucretenido")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.Tipomoneda)
                    .HasColumnName("tipomoneda")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Retenedores>(entity =>
            {
                entity.ToTable("retenedores");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Rucretenedor)
                    .IsRequired()
                    .HasColumnName("rucretenedor")
                    .HasColumnType("varchar(14)");
            });

            modelBuilder.Entity<TipoCambios>(entity =>
            {
                entity.ToTable("tipo_cambios");

                entity.HasIndex(e => e.Fecha)
                    .HasName("Index_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Tipocambio)
                    .HasColumnName("tipocambio")
                    .HasColumnType("decimal(8,4)");
            });

            modelBuilder.Entity<Traslados>(entity =>
            {
                entity.ToTable("traslados");

                entity.HasIndex(e => e.Periodo)
                    .HasName("Index_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CantidadRegistros).HasColumnName("cantidad_registros");

                entity.Property(e => e.FechaTraslado)
                    .HasColumnName("fecha_traslado")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Periodo).HasColumnName("periodo");

                entity.Property(e => e.Rucretenedor)
                    .IsRequired()
                    .HasColumnName("rucretenedor")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasColumnType("varchar(30)");
            });
        }
    }
}
