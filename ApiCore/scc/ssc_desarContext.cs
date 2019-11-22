using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiCore.scc
{
    public partial class ssc_desarContext : DbContext
    {
        public ssc_desarContext()
        {
        }

        public ssc_desarContext(DbContextOptions<ssc_desarContext> options)
            : base(options)
        {
        }

   
        public virtual DbSet<Cargadatosdga> Cargadatosdga { get; set; }
        public virtual DbSet<CatastroCompradorInmuebles> CatastroCompradorInmuebles { get; set; }
        public virtual DbSet<CatastroCompradorMuebles> CatastroCompradorMuebles { get; set; }
        public virtual DbSet<CatastroInmuebles> CatastroInmuebles { get; set; }
        public virtual DbSet<CatastroMuebles> CatastroMuebles { get; set; }
        public virtual DbSet<CatastroPropCompra> CatastroPropCompra { get; set; }
        public virtual DbSet<CatastroPropietarioInmuebles> CatastroPropietarioInmuebles { get; set; }
        public virtual DbSet<CatastroPropietarioMuebles> CatastroPropietarioMuebles { get; set; }       
        public virtual DbSet<CategorizadoMoroso> CategorizadoMoroso { get; set; }
        public virtual DbSet<CategorizadoMorosof> CategorizadoMorosof { get; set; }
        public virtual DbSet<DgiDetalleCreditoIva> DgiDetalleCreditoIva { get; set; }
        public virtual DbSet<DgiDetalleRetenciones> DgiDetalleRetenciones { get; set; }
        public virtual DbSet<DgiExentos> DgiExentos { get; set; }
        public virtual DbSet<IrivaAutotraslacionProveedor> IrivaAutotraslacionProveedor { get; set; }
        public virtual DbSet<IrivaAutotraslacionRetenido> IrivaAutotraslacionRetenido { get; set; }
        public virtual DbSet<IrivaDetalleRetenciones> IrivaDetalleRetenciones { get; set; }
        public virtual DbSet<IrivaProveedor> IrivaProveedor { get; set; }
        public virtual DbSet<IrivaRetenedor> IrivaRetenedor { get; set; }        
        public virtual DbSet<SolvenciaCero> SolvenciaCero { get; set; }   
        public virtual DbSet<TipoCambio> TipoCambio { get; set; }
        public virtual DbSet<TipoCambios> TipoCambios { get; set; }


        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=10.16.216.88;User Id=mmartinez;Password=desar2017*;Database=ssc_desar");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatastroInmuebles>(entity =>
            {
                entity.HasKey(e => e.IsnDgiCatastro)
                    .HasName("PRIMARY");

                entity.ToTable("catastro_inmuebles");

                entity.HasIndex(e => e.CodRenta)
                    .HasName("cod_renta");

                entity.HasIndex(e => e.Estado)
                    .HasName("estado");

                entity.HasIndex(e => e.NumIdentificacionComp)
                    .HasName("ncomp");

                entity.HasIndex(e => e.NumIdentificacionProp)
                    .HasName("nprop");

                entity.HasIndex(e => e.TipoAvaluo)
                    .HasName("tipo_ava");

                entity.Property(e => e.IsnDgiCatastro)
                    .HasColumnName("ISN_DGI_CATASTRO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Ano)
                    .HasColumnName("ANO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Apellido1Comp)
                    .HasColumnName("APELLIDO1_COMP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Apellido1Prop)
                    .HasColumnName("APELLIDO1_PROP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Apellido2Comp)
                    .HasColumnName("APELLIDO2_COMP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Apellido2Prop)
                    .HasColumnName("APELLIDO2_PROP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.AreaEstructura)
                    .HasColumnName("AREA_ESTRUCTURA")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.AreaTerreno)
                    .HasColumnName("AREA_TERRENO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.BaseLegal)
                    .HasColumnName("BASE_LEGAL")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.CausaExoneracion)
                    .HasColumnName("CAUSA_EXONERACION")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.CodRenta)
                    .HasColumnName("COD_RENTA")
                    .HasColumnType("int(10)");

                entity.Property(e => e.CodRentaTrans)
                    .HasColumnName("COD_RENTA_TRANS")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DeptMunDistComp)
                    .HasColumnName("DEPT_MUN_DIST_COMP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DeptMunDistInmueble)
                    .HasColumnName("DEPT_MUN_DIST_INMUEBLE")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DeptMunDistProp)
                    .HasColumnName("DEPT_MUN_DIST_PROP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DireccionComp)
                    .HasColumnName("DIRECCION_COMP")
                    .HasColumnType("varchar(70)");

                entity.Property(e => e.DireccionProp)
                    .HasColumnName("DIRECCION_PROP")
                    .HasColumnType("varchar(70)");

                entity.Property(e => e.DocOriginal)
                    .HasColumnName("DOC_ORIGINAL")
                    .HasColumnType("double(13,0)");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaAdquisicion)
                    .HasColumnName("FECHA_ADQUISICION")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaConsolid)
                    .HasColumnName("FECHA_CONSOLID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEmisionRepLegal)
                    .HasColumnName("FECHA_EMISION_REP_LEGAL")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEmisionTram)
                    .HasColumnName("FECHA_EMISION_TRAM")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEnajenacion)
                    .HasColumnName("FECHA_ENAJENACION")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaExentos)
                    .HasColumnName("FECHA_EXENTOS")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaInscripcionAvaluo)
                    .HasColumnName("FECHA_INSCRIPCION_AVALUO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaModifAvaluo)
                    .HasColumnName("FECHA_MODIF_AVALUO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("FECHA_PAGO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaProceso)
                    .HasColumnName("FECHA_PROCESO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaResolucion)
                    .HasColumnName("FECHA_RESOLUCION")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdCatastro)
                    .HasColumnName("ID_CATASTRO")
                    .HasColumnType("varchar(34)");

                entity.Property(e => e.IdRazonAvaluo)
                    .HasColumnName("ID_RAZON_AVALUO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Instancia)
                    .HasColumnName("INSTANCIA")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.NacionalidadComp)
                    .HasColumnName("NACIONALIDAD_COMP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.NacionalidadProp)
                    .HasColumnName("NACIONALIDAD_PROP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.NombreFuncionario)
                    .HasColumnName("NOMBRE_FUNCIONARIO")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.NombresApellidosTram)
                    .HasColumnName("NOMBRES_APELLIDOS_TRAM")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NombresComp)
                    .HasColumnName("NOMBRES_COMP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.NombresProp)
                    .HasColumnName("NOMBRES_PROP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.NombsApellisRepLegal)
                    .HasColumnName("NOMBS_APELLIS_REP_LEGAL")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NumAsientoOtros)
                    .HasColumnName("NUM_ASIENTO_OTROS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumCatastralClase)
                    .HasColumnName("NUM_CATASTRAL_CLASE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumCertificado)
                    .HasColumnName("NUM_CERTIFICADO")
                    .HasColumnType("double(10,0)");

                entity.Property(e => e.NumChasis)
                    .HasColumnName("NUM_CHASIS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumDocIdentRepLegal)
                    .HasColumnName("NUM_DOC_IDENT_REP_LEGAL")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NumDocIdentidadTram)
                    .HasColumnName("NUM_DOC_IDENTIDAD_TRAM")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("NUM_DOCUMENTO")
                    .HasColumnType("double(13,0)");

                entity.Property(e => e.NumEscritura)
                    .HasColumnName("NUM_ESCRITURA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.NumFallo)
                    .HasColumnName("NUM_FALLO")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.NumFolioColor)
                    .HasColumnName("NUM_FOLIO_COLOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumIdentificacionComp)
                    .HasColumnName("NUM_IDENTIFICACION_COMP")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NumIdentificacionProp)
                    .HasColumnName("NUM_IDENTIFICACION_PROP")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NumMotor)
                    .HasColumnName("NUM_MOTOR")
                    .HasColumnType("varchar(23)");

                entity.Property(e => e.NumPapelSelladoRepLegal)
                    .HasColumnName("NUM_PAPEL_SELLADO_REP_LEGAL")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NumPapelSelladoTram)
                    .HasColumnName("NUM_PAPEL_SELLADO_TRAM")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumRegistroPlaca)
                    .HasColumnName("NUM_REGISTRO_PLACA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumResolExentos)
                    .HasColumnName("NUM_RESOL_EXENTOS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumSoportePago)
                    .HasColumnName("NUM_SOPORTE_PAGO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.NumTomoMarca)
                    .HasColumnName("NUM_TOMO_MARCA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumeroIndivisa)
                    .HasColumnName("NUMERO_INDIVISA")
                    .HasColumnType("int(10)");

                entity.Property(e => e.NumeroValuacion)
                    .HasColumnName("NUMERO_VALUACION")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ObservacionTram)
                    .HasColumnName("OBSERVACION_TRAM")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("PORCENTAJE")
                    .HasColumnType("double(4,2)");

                entity.Property(e => e.RazonSocialComp)
                    .HasColumnName("RAZON_SOCIAL_COMP")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RazonSocialProp)
                    .HasColumnName("RAZON_SOCIAL_PROP")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RucSeguridad)
                    .HasColumnName("RUC_SEGURIDAD")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoAvaluo)
                    .HasColumnName("TIPO_AVALUO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoDocIdentComp)
                    .HasColumnName("TIPO_DOC_IDENT_COMP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoDocIdentProp)
                    .HasColumnName("TIPO_DOC_IDENT_PROP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoIdentTramite)
                    .HasColumnName("TIPO_IDENT_TRAMITE")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoResol)
                    .HasColumnName("TIPO_RESOL")
                    .HasColumnType("int(10)");

                entity.Property(e => e.UbicacionInmueble)
                    .HasColumnName("UBICACION_INMUEBLE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ValorCatastral)
                    .HasColumnName("VALOR_CATASTRAL")
                    .HasColumnType("double(13,2)");

                entity.Property(e => e.ValorEnajDeclarado)
                    .HasColumnName("VALOR_ENAJ_DECLARADO")
                    .HasColumnType("double(13,2)");

                entity.Property(e => e.ValorEstructura)
                    .HasColumnName("VALOR_ESTRUCTURA")
                    .HasColumnType("double(13,2)");

                entity.Property(e => e.ValorPagar)
                    .HasColumnName("VALOR_PAGAR")
                    .HasColumnType("double(13,2)");

                entity.Property(e => e.ValorTerreno)
                    .HasColumnName("VALOR_TERRENO")
                    .HasColumnType("double(13,2)");
            });

            modelBuilder.Entity<CatastroMuebles>(entity =>
            {
                entity.HasKey(e => e.IsnDgiCatastro)
                    .HasName("PRIMARY");

                entity.ToTable("catastro_muebles");

                entity.HasIndex(e => e.CodRenta)
                    .HasName("cod_renta");

                entity.HasIndex(e => e.Estado)
                    .HasName("estado");

                entity.HasIndex(e => e.NumIdentificacionComp)
                    .HasName("ncomp");

                entity.HasIndex(e => e.NumIdentificacionProp)
                    .HasName("nprop");

                entity.HasIndex(e => e.TipoAvaluo)
                    .HasName("tipo_ava");

                entity.Property(e => e.IsnDgiCatastro)
                    .HasColumnName("ISN_DGI_CATASTRO")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Ano)
                    .HasColumnName("ANO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Apellido1Comp)
                    .HasColumnName("APELLIDO1_COMP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Apellido1Prop)
                    .HasColumnName("APELLIDO1_PROP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Apellido2Comp)
                    .HasColumnName("APELLIDO2_COMP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Apellido2Prop)
                    .HasColumnName("APELLIDO2_PROP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.AreaEstructura)
                    .HasColumnName("AREA_ESTRUCTURA")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.AreaTerreno)
                    .HasColumnName("AREA_TERRENO")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.BaseLegal)
                    .HasColumnName("BASE_LEGAL")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.CausaExoneracion)
                    .HasColumnName("CAUSA_EXONERACION")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.CodRenta)
                    .HasColumnName("COD_RENTA")
                    .HasColumnType("int(10)");

                entity.Property(e => e.CodRentaTrans)
                    .HasColumnName("COD_RENTA_TRANS")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DeptMunDistComp)
                    .HasColumnName("DEPT_MUN_DIST_COMP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DeptMunDistInmueble)
                    .HasColumnName("DEPT_MUN_DIST_INMUEBLE")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DeptMunDistProp)
                    .HasColumnName("DEPT_MUN_DIST_PROP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.DireccionComp)
                    .HasColumnName("DIRECCION_COMP")
                    .HasColumnType("varchar(70)");

                entity.Property(e => e.DireccionProp)
                    .HasColumnName("DIRECCION_PROP")
                    .HasColumnType("varchar(70)");

                entity.Property(e => e.DocOriginal)
                    .HasColumnName("DOC_ORIGINAL")
                    .HasColumnType("double(13,0)");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaAdquisicion)
                    .HasColumnName("FECHA_ADQUISICION")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaConsolid)
                    .HasColumnName("FECHA_CONSOLID")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEmision)
                    .HasColumnName("FECHA_EMISION")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEmisionRepLegal)
                    .HasColumnName("FECHA_EMISION_REP_LEGAL")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEmisionTram)
                    .HasColumnName("FECHA_EMISION_TRAM")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEnajenacion)
                    .HasColumnName("FECHA_ENAJENACION")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("FECHA_ENTREGA")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaExentos)
                    .HasColumnName("FECHA_EXENTOS")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaInscripcionAvaluo)
                    .HasColumnName("FECHA_INSCRIPCION_AVALUO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaModifAvaluo)
                    .HasColumnName("FECHA_MODIF_AVALUO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("FECHA_PAGO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaProceso)
                    .HasColumnName("FECHA_PROCESO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaResolucion)
                    .HasColumnName("FECHA_RESOLUCION")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdCatastro)
                    .HasColumnName("ID_CATASTRO")
                    .HasColumnType("varchar(34)");

                entity.Property(e => e.IdRazonAvaluo)
                    .HasColumnName("ID_RAZON_AVALUO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Instancia)
                    .HasColumnName("INSTANCIA")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.NacionalidadComp)
                    .HasColumnName("NACIONALIDAD_COMP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.NacionalidadProp)
                    .HasColumnName("NACIONALIDAD_PROP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.NombreFuncionario)
                    .HasColumnName("NOMBRE_FUNCIONARIO")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.NombresApellidosTram)
                    .HasColumnName("NOMBRES_APELLIDOS_TRAM")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NombresComp)
                    .HasColumnName("NOMBRES_COMP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.NombresProp)
                    .HasColumnName("NOMBRES_PROP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.NombsApellisRepLegal)
                    .HasColumnName("NOMBS_APELLIS_REP_LEGAL")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NumAsientoOtros)
                    .HasColumnName("NUM_ASIENTO_OTROS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumCatastralClase)
                    .HasColumnName("NUM_CATASTRAL_CLASE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumCertificado)
                    .HasColumnName("NUM_CERTIFICADO")
                    .HasColumnType("double(10,0)");

                entity.Property(e => e.NumChasis)
                    .HasColumnName("NUM_CHASIS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumDocIdentRepLegal)
                    .HasColumnName("NUM_DOC_IDENT_REP_LEGAL")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NumDocIdentidadTram)
                    .HasColumnName("NUM_DOC_IDENTIDAD_TRAM")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("NUM_DOCUMENTO")
                    .HasColumnType("double(13,0)");

                entity.Property(e => e.NumEscritura)
                    .HasColumnName("NUM_ESCRITURA")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.NumFallo)
                    .HasColumnName("NUM_FALLO")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.NumFolioColor)
                    .HasColumnName("NUM_FOLIO_COLOR")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumIdentificacionComp)
                    .HasColumnName("NUM_IDENTIFICACION_COMP")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NumIdentificacionProp)
                    .HasColumnName("NUM_IDENTIFICACION_PROP")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NumMotor)
                    .HasColumnName("NUM_MOTOR")
                    .HasColumnType("varchar(23)");

                entity.Property(e => e.NumPapelSelladoRepLegal)
                    .HasColumnName("NUM_PAPEL_SELLADO_REP_LEGAL")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NumPapelSelladoTram)
                    .HasColumnName("NUM_PAPEL_SELLADO_TRAM")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumRegistroPlaca)
                    .HasColumnName("NUM_REGISTRO_PLACA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumResolExentos)
                    .HasColumnName("NUM_RESOL_EXENTOS")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumSoportePago)
                    .HasColumnName("NUM_SOPORTE_PAGO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.NumTomoMarca)
                    .HasColumnName("NUM_TOMO_MARCA")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.NumeroIndivisa)
                    .HasColumnName("NUMERO_INDIVISA")
                    .HasColumnType("int(10)");

                entity.Property(e => e.NumeroValuacion)
                    .HasColumnName("NUMERO_VALUACION")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ObservacionTram)
                    .HasColumnName("OBSERVACION_TRAM")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("PORCENTAJE")
                    .HasColumnType("double(4,2)");

                entity.Property(e => e.RazonSocialComp)
                    .HasColumnName("RAZON_SOCIAL_COMP")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RazonSocialProp)
                    .HasColumnName("RAZON_SOCIAL_PROP")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RucSeguridad)
                    .HasColumnName("RUC_SEGURIDAD")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoAvaluo)
                    .HasColumnName("TIPO_AVALUO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoDocIdentComp)
                    .HasColumnName("TIPO_DOC_IDENT_COMP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoDocIdentProp)
                    .HasColumnName("TIPO_DOC_IDENT_PROP")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoIdentTramite)
                    .HasColumnName("TIPO_IDENT_TRAMITE")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoResol)
                    .HasColumnName("TIPO_RESOL")
                    .HasColumnType("int(10)");

                entity.Property(e => e.UbicacionInmueble)
                    .HasColumnName("UBICACION_INMUEBLE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ValorCatastral)
                    .HasColumnName("VALOR_CATASTRAL")
                    .HasColumnType("double(13,2)");

                entity.Property(e => e.ValorEnajDeclarado)
                    .HasColumnName("VALOR_ENAJ_DECLARADO")
                    .HasColumnType("double(13,2)");

                entity.Property(e => e.ValorEstructura)
                    .HasColumnName("VALOR_ESTRUCTURA")
                    .HasColumnType("double(13,2)");

                entity.Property(e => e.ValorPagar)
                    .HasColumnName("VALOR_PAGAR")
                    .HasColumnType("double(13,2)");

                entity.Property(e => e.ValorTerreno)
                    .HasColumnName("VALOR_TERRENO")
                    .HasColumnType("double(13,2)");
            });




            modelBuilder.Entity<Cargadatosdga>(entity =>
            {
                entity.ToTable("cargadatosdga");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<CatastroCompradorInmuebles>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("Catastro_CompradorINMUEBLES");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.Property(e => e.FechaProceso).HasColumnType("varchar(70)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.Ubicacion).HasColumnType("varchar(100)");

                entity.Property(e => e.ValorCatastral)
                    .HasColumnName("VALOR_CATASTRAL")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorDeclarado)
                    .HasColumnName("VALOR_DECLARADO")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorPagar)
                    .HasColumnName("VALOR_PAGAR")
                    .HasColumnType("decimal(13,2)");
            });

            modelBuilder.Entity<CatastroCompradorMuebles>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("Catastro_CompradorMUEBLES");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.Property(e => e.FechaProceso).HasColumnType("varchar(70)");

                entity.Property(e => e.Marca).HasColumnType("varchar(100)");

                entity.Property(e => e.NFactura)
                    .HasColumnName("N_factura")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.ValorCatastral)
                    .HasColumnName("VALOR_CATASTRAL")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorDeclarado)
                    .HasColumnName("VALOR_DECLARADO")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorPagar)
                    .HasColumnName("VALOR_PAGAR")
                    .HasColumnType("decimal(13,2)");
            });

            modelBuilder.Entity<CatastroPropCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("Catastro_PropCompra");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.FechaInscripcionAvaluo)
                    .HasColumnName("FECHA_INSCRIPCION_AVALUO")
                    .HasColumnType("date");

                entity.Property(e => e.FechaProceso)
                    .HasColumnName("FECHA_PROCESO")
                    .HasColumnType("date");

                entity.Property(e => e.IdentificacionComp)
                    .HasColumnName("IDENTIFICACION_COMP")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NombreComprador)
                    .HasColumnName("NOMBRE_COMPRADOR")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NombresApellidosTram)
                    .HasColumnName("NOMBRES_APELLIDOS_TRAM")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NombresProp)
                    .HasColumnName("NOMBRES_PROP")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.RazonSocialComp)
                    .HasColumnName("RAZON_SOCIAL_COMP")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.RazonSocialProp)
                    .HasColumnName("RAZON_SOCIAL_PROP")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.ValorCatastral)
                    .HasColumnName("VALOR_CATASTRAL")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorEnajDeclarado)
                    .HasColumnName("VALOR_ENAJ_DECLARADO")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorPagar)
                    .HasColumnName("VALOR_PAGAR")
                    .HasColumnType("decimal(13,2)");
            });

            modelBuilder.Entity<CatastroPropietarioInmuebles>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("Catastro_PropietarioINMUEBLES");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.Property(e => e.FechaProceso).HasColumnType("varchar(70)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.Ubicacion).HasColumnType("varchar(100)");

                entity.Property(e => e.ValorCatastral)
                    .HasColumnName("VALOR_CATASTRAL")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorDeclarado)
                    .HasColumnName("VALOR_DECLARADO")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorPagar)
                    .HasColumnName("VALOR_PAGAR")
                    .HasColumnType("decimal(13,2)");
            });

            modelBuilder.Entity<CatastroPropietarioMuebles>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("Catastro_PropietarioMUEBLES");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.Property(e => e.FechaProceso).HasColumnType("varchar(70)");

                entity.Property(e => e.Marca).HasColumnType("varchar(100)");

                entity.Property(e => e.NFactura)
                    .HasColumnName("N_factura")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.ValorCatastral)
                    .HasColumnName("VALOR_CATASTRAL")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorDeclarado)
                    .HasColumnName("VALOR_DECLARADO")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorPagar)
                    .HasColumnName("VALOR_PAGAR")
                    .HasColumnType("decimal(13,2)");
            });            

            modelBuilder.Entity<CategorizadoMoroso>(entity =>
            {
                entity.HasKey(e => e.IdC)
                    .HasName("PRIMARY");

                entity.ToTable("categorizado_moroso");

                entity.Property(e => e.IdC)
                    .HasColumnName("ID_C")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CodImpuesto)
                    .HasColumnName("COD_IMPUESTO")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.CodigoRenta).HasColumnType("int(10)");

                entity.Property(e => e.CodigoSubcategoria)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DescripcionRenta)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DescripcionSubcategoria).HasColumnType("varchar(50)");

                entity.Property(e => e.IdNit).HasColumnType("int(10)");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NombreRazon)
                    .HasColumnName("Nombre_Razon")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.NumeroTelefono1).HasColumnType("int(10)");

                entity.Property(e => e.NumeroTelefono2).HasColumnType("int(10)");

                entity.Property(e => e.NumeroTelefonoR).HasColumnType("int(10)");

                entity.Property(e => e.Periodo)
                    .HasColumnName("PERIODO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("double(15,2)");

                entity.Property(e => e.ValorImpuesto)
                    .HasColumnName("VALOR_IMPUESTO")
                    .HasColumnType("double(15,3)");

                entity.Property(e => e.ValorMantenimiento)
                    .HasColumnName("VALOR_MANTENIMIENTO")
                    .HasColumnType("double(10,2)");

                entity.Property(e => e.ValorMulta)
                    .HasColumnName("VALOR_MULTA")
                    .HasColumnType("double(15,3)");

                entity.Property(e => e.ValorRecargo)
                    .HasColumnName("VALOR_RECARGO")
                    .HasColumnType("double(10,2)");
            });

            modelBuilder.Entity<CategorizadoMorosof>(entity =>
            {
                entity.HasKey(e => e.IdC)
                    .HasName("PRIMARY");

                entity.ToTable("categorizado_morosof");

                entity.Property(e => e.IdC)
                    .HasColumnName("ID_C")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Celular).HasColumnType("int(10)");

                entity.Property(e => e.CodImpuesto)
                    .HasColumnName("COD_IMPUESTO")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.CodigoRenta).HasColumnType("int(10)");

                entity.Property(e => e.CodigoSubcategoria)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DescripcionRenta)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DescripcionSubcategoria).HasColumnType("varchar(50)");

                entity.Property(e => e.IdNit).HasColumnType("int(10)");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.NombreRazon)
                    .HasColumnName("Nombre_Razon")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.NumeroTelefono1).HasColumnType("int(10)");

                entity.Property(e => e.NumeroTelefono2).HasColumnType("int(10)");

                entity.Property(e => e.NumeroTelefonoR).HasColumnType("int(10)");

                entity.Property(e => e.Periodo)
                    .HasColumnName("PERIODO")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Telefonica).HasColumnType("varchar(20)");

                entity.Property(e => e.Total)
                    .HasColumnName("TOTAL")
                    .HasColumnType("double(15,2)");

                entity.Property(e => e.ValorImpuesto)
                    .HasColumnName("VALOR_IMPUESTO")
                    .HasColumnType("double(15,3)");

                entity.Property(e => e.ValorMantenimiento)
                    .HasColumnName("VALOR_MANTENIMIENTO")
                    .HasColumnType("double(10,2)");

                entity.Property(e => e.ValorMulta)
                    .HasColumnName("VALOR_MULTA")
                    .HasColumnType("double(15,3)");

                entity.Property(e => e.ValorRecargo)
                    .HasColumnName("VALOR_RECARGO")
                    .HasColumnType("double(10,2)");
            });          

            modelBuilder.Entity<DgaImportadores>(entity =>
            {
                entity.HasKey(e => e.Pkclave)
                    .HasName("PRIMARY");

                entity.ToTable("dga_importadores");

                entity.HasIndex(e => e.Declaracion)
                    .HasName("declaracion");

                entity.HasIndex(e => e.Ruc)
                    .HasName("ruc");

                entity.HasIndex(e => new { e.Ruc, e.Periodo })
                    .HasName("Rucperiodo");

                entity.Property(e => e.Pkclave)
                    .HasColumnName("pkclave")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CantItem)
                    .HasColumnName("cant_item")
                    .HasColumnType("decimal(11,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Declaracion)
                    .HasColumnName("declaracion")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DescMercaderia)
                    .HasColumnName("desc_mercaderia")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'--'");

                entity.Property(e => e.ExoDai)
                    .HasColumnName("exo_dai")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ExoIsc)
                    .HasColumnName("exo_isc")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ExoIso)
                    .HasColumnName("exo_iso")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ExoIva)
                    .HasColumnName("exo_iva")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.FechaCarga)
                    .HasColumnName("fecha_carga")
                    .HasColumnType("int(8)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaLiquida)
                    .HasColumnName("fecha_liquida")
                    .HasColumnType("int(10)");

                entity.Property(e => e.LiqDai)
                    .HasColumnName("liq_dai")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.LiqIsc)
                    .HasColumnName("liq_isc")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.LiqIso)
                    .HasColumnName("liq_iso")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.LiqIva)
                    .HasColumnName("liq_iva")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.PagDai)
                    .HasColumnName("pag_dai")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.PagIsc)
                    .HasColumnName("pag_isc")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.PagIso)
                    .HasColumnName("pag_iso")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.PagIva)
                    .HasColumnName("pag_iva")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo")
                    .HasColumnType("int(7)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.Serie)
                    .HasColumnName("serie")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("double(15,4)")
                    .HasDefaultValueSql("'0.0000'");

                entity.Property(e => e.TipoDeclar)
                    .HasColumnName("TIPO_DECLAR")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ValorCif)
                    .HasColumnName("valor_cif")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ValorFlete)
                    .HasColumnName("valor_flete")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ValorFob)
                    .HasColumnName("valor_fob")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ValorOtros)
                    .HasColumnName("valor_otros")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ValorSeguro)
                    .HasColumnName("valor_seguro")
                    .HasColumnType("double(15,2)")
                    .HasDefaultValueSql("'0.00'");
            });

            modelBuilder.Entity<DgiDetalleCreditoIva>(entity =>
            {
                entity.HasKey(e => e.IdDgiRetenciones)
                    .HasName("PRIMARY");

                entity.ToTable("DgiDetalleCreditoIVA");

                entity.HasIndex(e => e.Periodo)
                    .HasName("idx2");

                entity.HasIndex(e => new { e.RucDeclara, e.CodigoRenta })
                    .HasName("idx1");

                entity.HasIndex(e => new { e.CodConcepto, e.RucDeclara, e.Periodo, e.CodigoRenta, e.Estado })
                    .HasName("busqueda");

                entity.Property(e => e.IdDgiRetenciones)
                    .HasColumnName("ID_DGI_Retenciones")
                    .HasColumnType("bigint(11)");

                entity.Property(e => e.CodConcepto).HasColumnType("int(11)");

                entity.Property(e => e.CodigoRenta).HasColumnType("int(11)");

                entity.Property(e => e.CodigoRentaTrans).HasColumnType("int(11)");

                entity.Property(e => e.DescripcionPago).HasColumnType("varchar(30)");

                entity.Property(e => e.Estado).HasColumnType("int(11)");

                entity.Property(e => e.FechaEmision).HasColumnType("int(11)");

                entity.Property(e => e.FechaProceso).HasColumnType("date");

                entity.Property(e => e.Formulario).HasColumnType("int(11)");

                entity.Property(e => e.Iva).HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoSinImpuesto).HasColumnType("decimal(13,2)");

                entity.Property(e => e.NombreApellido).HasColumnType("varchar(30)");

                entity.Property(e => e.NumDocumento).HasColumnType("varchar(30)");

                entity.Property(e => e.NumResolucion).HasColumnType("decimal(13,2)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.RucDeclara).HasColumnType("varchar(20)");

                entity.Property(e => e.RucRetenido).HasColumnType("varchar(20)");

                entity.Property(e => e.TipoProceso).HasColumnType("int(11)");
            });

            modelBuilder.Entity<DgiDetalleRetenciones>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.RucRetenido)
                    .HasName("jdx2");

                entity.HasIndex(e => new { e.RucDeclara, e.Periodo, e.CodigoRenta, e.CodConcepto, e.Estado })
                    .HasName("idx3");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.Alicuota).HasColumnType("int(11)");

                entity.Property(e => e.BaseImponible).HasColumnType("decimal(13,2)");

                entity.Property(e => e.CodConcepto)
                    .HasColumnName("Cod_concepto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoRenta).HasColumnType("int(11)");

                entity.Property(e => e.CodigoRentaTrans).HasColumnType("int(11)");

                entity.Property(e => e.Estado).HasColumnType("int(11)");

                entity.Property(e => e.FechaProceso).HasColumnType("date");

                entity.Property(e => e.Formulario).HasColumnType("int(11)");

                entity.Property(e => e.IngresosBrutos).HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoInss).HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoPension).HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoRetenido).HasColumnType("decimal(13,2)");

                entity.Property(e => e.NombreApellido).HasColumnType("varchar(30)");

                entity.Property(e => e.NumResolucion).HasColumnType("bigint(11)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.RucDeclara).HasColumnType("varchar(14)");

                entity.Property(e => e.RucRetenido).HasColumnType("varchar(14)");

                entity.Property(e => e.TipoProceso).HasColumnType("int(11)");
            });

            modelBuilder.Entity<DgiExentos>(entity =>
            {
                entity.HasKey(e => e.CodExento)
                    .HasName("PRIMARY");

                entity.ToTable("dgi_exentos");

                entity.HasIndex(e => e.Ruc)
                    .HasName("ruc");

                entity.Property(e => e.CodExento)
                    .HasColumnName("Cod_exento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(80)");
            });

            modelBuilder.Entity<IrivaAutotraslacionProveedor>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("IRIVA_autotraslacionProveedor");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.MontoIvaAutotrasladado)
                    .HasColumnName("Monto_IVA_Autotrasladado")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoSinImpuesto)
                    .HasColumnName("Monto_Sin_Impuesto")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ValorRetenido)
                    .HasColumnName("Valor_Retenido")
                    .HasColumnType("decimal(13,2)");
            });

            modelBuilder.Entity<IrivaAutotraslacionRetenido>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("IRIVA_AutotraslacionRetenido");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.BaseImponible)
                    .HasColumnName("Base_Imponible")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.CodRenglonRengloIva)
                    .HasColumnName("Cod_Renglon_Renglo_IVA")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodRenglonRetenido)
                    .HasColumnName("Cod_RenglonRetenido")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IngresosBrutos).HasColumnType("decimal(13,2)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ValorRetenido)
                    .HasColumnName("Valor_Retenido")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorSinImpuesto)
                    .HasColumnName("Valor_Sin_Impuesto")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorTrasladado)
                    .HasColumnName("Valor_Trasladado")
                    .HasColumnType("decimal(13,2)");
            });

            modelBuilder.Entity<IrivaDetalleRetenciones>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("IRIVA_DetalleRetenciones");

                entity.HasIndex(e => e.RucRetenido)
                    .HasName("jdx2");

                entity.HasIndex(e => new { e.Ruc, e.Periodo, e.CodigoRenta, e.CodConcepto, e.Estado })
                    .HasName("idx3");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.Alicuota).HasColumnType("int(11)");

                entity.Property(e => e.BaseImponible).HasColumnType("decimal(13,2)");

                entity.Property(e => e.CodConcepto)
                    .HasColumnName("Cod_concepto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoRenta).HasColumnType("int(11)");

                entity.Property(e => e.CodigoRentaTrans).HasColumnType("int(11)");

                entity.Property(e => e.Estado).HasColumnType("int(11)");

                entity.Property(e => e.FechaProceso).HasColumnType("date");

                entity.Property(e => e.Formulario).HasColumnType("int(11)");

                entity.Property(e => e.IngresosBrutos).HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoInss).HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoPension).HasColumnType("decimal(13,2)");

                entity.Property(e => e.MontoRetenido).HasColumnType("decimal(13,2)");

                entity.Property(e => e.NombreApellido).HasColumnType("varchar(30)");

                entity.Property(e => e.NumResolucion).HasColumnType("bigint(11)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.RucRetenido).HasColumnType("varchar(14)");

                entity.Property(e => e.TipoProceso).HasColumnType("int(11)");
            });

            modelBuilder.Entity<IrivaProveedor>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("IRIVA_Proveedor");

                entity.HasIndex(e => e.Periodo)
                    .HasName("Periodoi");

                entity.HasIndex(e => e.Ruc)
                    .HasName("ruci");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(14)");

                entity.Property(e => e.AlicuotaDeRetencion)
                    .HasColumnName("Alicuota_de_Retencion")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.BaseImponible)
                    .HasColumnName("Base_Imponible")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CodConcepto)
                    .HasColumnName("Cod_concepto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodRetenc).HasColumnType("int(10)");

                entity.Property(e => e.IngresosBrutos)
                    .HasColumnName("Ingresos_Brutos")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.MontoInss).HasColumnType("decimal(15,2)");

                entity.Property(e => e.Periodo).HasColumnType("varchar(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tabla).HasColumnType("int(10)");

                entity.Property(e => e.ValorRetenido)
                    .HasColumnName("Valor_Retenido")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.ValorSinImpuesto)
                    .HasColumnName("Valor_Sin_Impuesto")
                    .HasColumnType("decimal(15,2)");
            });

            modelBuilder.Entity<IrivaRetenedor>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("IRIVA_retenedor");

                entity.HasIndex(e => e.Periodo)
                    .HasName("Per");

                entity.HasIndex(e => e.Ruc)
                    .HasName("rucr");

                entity.Property(e => e.IdDetalle).HasColumnType("bigint(11)");

                entity.Property(e => e.BaseImponible)
                    .HasColumnName("Base_Imponible")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.CodRenglonIvaCreditoFiscal)
                    .HasColumnName("Cod_Renglon_IVA_Credito_Fiscal")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.CodigoRenglonRetenido)
                    .HasColumnName("Codigo_Renglon_Retenido")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IngresosBrutos)
                    .HasColumnName("Ingresos_Brutos")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.Periodo).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Tabla).HasColumnType("int(10)");

                entity.Property(e => e.ValorCotizacion)
                    .HasColumnName("Valor_Cotizacion")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.ValorRetenido)
                    .HasColumnName("Valor_Retenido")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.ValorSinImpuesto)
                    .HasColumnName("Valor_Sin_Impuesto")
                    .HasColumnType("decimal(15,2)");
            });

            modelBuilder.Entity<SolvenciaCero>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Contador)
                    .HasColumnName("CONTADOR")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Periodo)
                    .HasColumnName("PERIODO")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Renta)
                    .HasColumnName("RENTA")
                    .HasColumnType("varchar(255)");
            });
            
            modelBuilder.Entity<TipoCambio>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ano).HasColumnType("int(11)");

                entity.Property(e => e.Cargado).HasColumnType("tinyint(1)");

                entity.Property(e => e.Dia).HasColumnType("int(11)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Mes).HasColumnType("int(11)");

                entity.Property(e => e.Tc)
                    .HasColumnName("TC")
                    .HasDefaultValueSql("'0'");
            });
           
            modelBuilder.Entity<TipoCambios>(entity =>
            {
                entity.ToTable("tipo_cambios");

                entity.HasIndex(e => e.Fecha)
                    .HasName("idx1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Tipocambio)
                    .HasColumnName("tipocambio")
                    .HasColumnType("decimal(8,4)");
            });
            
        }
    }
}
