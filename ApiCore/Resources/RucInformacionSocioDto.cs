using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucInformacionSocioDto
    {
        public int IdSocio { get; set; }
        public int IdNit { get; set; }
        public int EstadoSocio { get; set; }
        public string NombreRazonSocialSocio { get; set; }
        public int TipoPersonaSocio { get; set; }
        public decimal ParticipacionSocio { get; set; }
        public int CodigoDocIdentificacionSocio { get; set; }
        public string NumeroIdentidadSocio { get; set; }
        public Nullable<double> NumeroRegistroresidenciaSocio { get; set; }
        public Nullable<System.DateTime> FechaEmisionDocuemnto { get; set; }
        public Nullable<System.DateTime> FechaVencimientoDocumento { get; set; }
        public Nullable<int> TipoResidenciaSocio { get; set; }
        public string ColoniaBarrioSocio { get; set; }
        public Nullable<int> CodigoDepartamento { get; set; }
        public Nullable<int> CodigoMunicipio { get; set; }
        public Nullable<int> CodigoDistrito { get; set; }
        public Nullable<int> CodigoPais { get; set; }
        public string CasaNoSocio { get; set; }
        public Nullable<int> TelefonoSocio { get; set; }
        public Nullable<int> FaxSocio { get; set; }
        public string ApartadoPostalSocio { get; set; }
        public string CorreoElectronicoSocio { get; set; }
        public Nullable<int> RucSocio { get; set; }
        public string NitSocio { get; set; }
        public Nullable<int> CodigoRentaTrans { get; set; }
        public string NombreRepresLegalSocio { get; set; }
        public Nullable<int> CodDocIdenRepresSocio { get; set; }
        public string NumIdentRepresSocio { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> CantidadAcciones { get; set; }
        public Nullable<int> Telefono2 { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual RucDto RucDto { get; set; }
        public virtual RentaDto RentaDto { get; set; }
    }
}
