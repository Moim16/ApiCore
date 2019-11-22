using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucObligacionDto
    {
        public int IdObligacion { get; set; }
        public int IdNit { get; set; }
        public int EstadoObligacion { get; set; }
        public int CodigoImpuesto { get; set; }
        public int Periodicidad { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<int> NumeroFormulario { get; set; }
        public Nullable<int> TipoFormulario { get; set; }
        public Nullable<System.DateTime> FechaFormulario { get; set; }
        public Nullable<int> ModifPeriodicidad { get; set; }
        public Nullable<int> ModifFechaInicio { get; set; }
        public Nullable<int> RucSeguridad { get; set; }
        public Nullable<System.DateTime> FechaConsolidacion { get; set; }
        public Nullable<int> PeriodoEspecial { get; set; }
        public int CodigoRenta { get; set; }
        public int CodigoRentaTransaccion { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> CodAgenciaFisc { get; set; }

        public virtual RucDto RucDto { get; set; }
        public virtual RentaDto RentaDto { get; set; }
    }
}
