using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucInformacionFinancieraDto
    {
        public int Id { get; set; }
        public int IdNit { get; set; }
        public Nullable<decimal> ActivosCorrientes { get; set; }
        public Nullable<decimal> ActivosFijos { get; set; }
        public Nullable<decimal> Pasivo { get; set; }
        public Nullable<decimal> Patrimonio { get; set; }
        public Nullable<int> OrigenCapital { get; set; }
        public Nullable<decimal> CapitalSociedad { get; set; }
        public Nullable<long> CantAcciones { get; set; }
        public Nullable<int> CantVehiculo { get; set; }
        public Nullable<int> TipoBien { get; set; }
        public Nullable<decimal> ValorVehiculos { get; set; }
        public Nullable<int> CantidadPropiedades { get; set; }
        public Nullable<decimal> ValorPropiedades { get; set; }
        public Nullable<decimal> Capital { get; set; }
        public Nullable<decimal> ValorInventario { get; set; }
        public Nullable<decimal> IngresoBrutoAnual { get; set; }
        public int CodigoRenta { get; set; }
        public Nullable<int> CantidadRural { get; set; }
        public Nullable<int> CantidadUrbana { get; set; }
        public Nullable<decimal> OtrosActivos { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual RucDto RucDto { get; set; }
        public virtual RentaDto RentaDto { get; set; }
    }
}
