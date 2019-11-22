using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucDto
    {
        //public RucDto()
        //{
        //    this.RucCategoriasDto = new HashSet<RucCategoriaDto>();
        //    this.RucCertificacionsDto = new HashSet<RucCertificacionDto>();
        //    this.RucCiiusDto = new HashSet<RucCiiuDto>();
        //    this.RucInformacionFinancierasDto = new HashSet<RucInformacionFinancieraDto>();
        //    this.RucInformacionSociosDto = new HashSet<RucInformacionSocioDto>();
        //    this.RucJuntaDirectivasDto = new HashSet<RucJuntaDirectivaDto>();
        //    this.RucObligacionsDto = new HashSet<RucObligacionDto>();
        //    this.RucEmpleadorsDto = new HashSet<RucEmpleadorDto>();

        //}
        public int IdNit { get; set; }
        public string Nit { get; set; }
        public int TipoRuc { get; set; }
        public int CodigoRenta { get; set; }
        public Nullable<int> Estado { get; set; }
        public string Ubicacion { get; set; }
        public string Numero { get; set; }
        public string ApartadoOficina { get; set; }
        public int TipoResidencia { get; set; }
        public string ColoniaBarrio { get; set; }
        public int CodigoDepartamento { get; set; }
        public int CodigoMunicipio { get; set; }
        public Nullable<int> CodigoDistrito { get; set; }
        public Nullable<int> NumeroFax { get; set; }
        public string CorreoElectronico { get; set; }
        public Nullable<int> NumeroTelefono1 { get; set; }
        public Nullable<int> NumeroTelefono2 { get; set; }
        public int CodigoPais { get; set; }
        public Nullable<int> TipoBaja { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<int> RucReceptorActivo { get; set; }
        public string NitReceptor { get; set; }
        public Nullable<int> IdCodImportancia { get; set; }
        public Nullable<int> IndCodUnidad { get; set; }
        public Nullable<System.DateTime> FechaIncorporar { get; set; }
        public Nullable<int> IdCodigoOperacion { get; set; }
        public Nullable<int> NumeroOrden { get; set; }
        public string ControlActualizacion { get; set; }
        public int CodigoRentaTransaccion { get; set; }
        public Nullable<int> CtrlNit { get; set; }
        public Nullable<System.DateTime> FechaEmpadrona { get; set; }
        public string NombreComercial { get; set; }
        public Nullable<int> CantidadEmpleados { get; set; }
        public string NoInss { get; set; }
        public Nullable<int> CodigoInstitucionReguladora { get; set; }
        
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }
        public string DocumentoBaja { get; set; }
        public string Numero_dui { get; set; }
        public string NoContribuyente_alma { get; set; }
        public Nullable<int> CodigoProductoLider { get; set; }
        public Nullable<int> CodAgenciaFisc { get; set; }
        public Nullable<int> Codsector { get; set; }
        public Nullable<int> CodBarrio { get; set; }
        public Nullable<int> CodDistSectorComercial { get; set; }
        public string NumeroNIS { get; set; }
        public string NumeroCuentaEnacal { get; set; }
        public string NumeroCuentaClaro { get; set; }

        public List<RucCategoriaDto> RucCategoriasDto { get; set; }
        public virtual ICollection<RucCertificacionDto> RucCertificacionsDto { get; set; }
        public virtual ICollection<RucCiiuDto> RucCiiusDto { get; set; }
        public virtual ICollection<RucInformacionFinancieraDto> RucInformacionFinancierasDto { get; set; }

        public virtual ICollection<RucInformacionSocioDto> RucInformacionSociosDto { get; set; }
        public virtual ICollection<RucJuntaDirectivaDto> RucJuntaDirectivasDto { get; set; }
        public virtual RucJuridicaDto RucJuridicaDto { get; set; }
        public virtual RucNaturalDto RucNaturalDto { get; set; }
        public virtual ICollection<RucObligacionDto> RucObligacionsDto { get; set; }
        public virtual ICollection<RucEmpleadorDto> RucEmpleadorsDto { get; set; }

        public virtual RentaDto RentaDto { get; set; }
    }
}
