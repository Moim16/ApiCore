using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucNaturalDto
    {
        public int IdNit { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Nombres { get; set; }
        public int Sexo { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaFallecimiento { get; set; }
        public int CodDocIdentificacion { get; set; }
        public string NumIdentidad { get; set; }
        public Nullable<int> CodExpedicion { get; set; }
        public string Regimen { get; set; }
        public string UbicacionDomicilio { get; set; }
        public Nullable<long> TelDomicilio { get; set; }
        public string NumCasaDomicilio { get; set; }
        public string ColoniaBarrioDomicilio { get; set; }
        public int FaxDomicilio { get; set; }
        public string CorreoElectronicoDomicilio { get; set; }
        public string AptoPostalDomicilio { get; set; }
        public Nullable<int> CodigoDepartamentoDomicilio { get; set; }
        public Nullable<int> CodigoMunicipioDomicilio { get; set; }
        public Nullable<int> CodigoDistritoDomicilio { get; set; }
        public Nullable<double> NumeroRegistro { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<int> Telefono2 { get; set; }
        public Nullable<int> CodigoEspecialidad { get; set; }
        public Nullable<int> TIpoResidencia { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual RucDto RucDto { get; set; }
    }
}
