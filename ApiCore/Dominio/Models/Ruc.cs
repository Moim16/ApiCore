using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Models
{
    public class Ruc
    {

        private HashSet<RucCategoria> rucCategorias;

        public Ruc()
        {
            this.RucCategorias = new HashSet<RucCategoria>();
            this.RucCertificacions = new HashSet<RucCertificacion>();
            this.RucCiius = new HashSet<RucCiiu>();
            this.RucInformacionFinancieras = new HashSet<RucInformacionFinanciera>();
            this.RucInformacionSocios = new HashSet<RucInformacionSocio>();
            this.RucJuntaDirectivas = new HashSet<RucJuntaDirectiva>();
            this.RucObligacions = new HashSet<RucObligacion>();
            this.RucEmpleadors = new HashSet<RucEmpleador>();
        }
        [Key]
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
        public virtual ICollection<RucCategoria> RucCategorias { get; set; }
        public virtual ICollection<RucCertificacion> RucCertificacions { get; set; }
        public virtual ICollection<RucCiiu> RucCiius { get; set; }
        public virtual ICollection<RucInformacionFinanciera> RucInformacionFinancieras { get; set; }
     
        public virtual ICollection<RucInformacionSocio> RucInformacionSocios { get; set; }
        public virtual ICollection<RucJuntaDirectiva> RucJuntaDirectivas { get; set; }
        public virtual RucJuridica RucJuridica { get; set; }
        public virtual RucNatural RucNatural { get; set; }
        public virtual ICollection<RucObligacion> RucObligacions { get; set; }
        public virtual ICollection<RucEmpleador> RucEmpleadors { get; set; }
       
        public virtual Renta Renta { get; set; }
       // public ICollection<RucCategoria> RucCategorias { get => rucCategorias; set => rucCategorias = new HashSet<RucCategoria>(value); }
    }
}
