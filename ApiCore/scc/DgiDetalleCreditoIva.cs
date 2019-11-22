using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class DgiDetalleCreditoIva
    {
        public long IdDgiRetenciones { get; set; }
        public string RucRetenido { get; set; }
        public string NumDocumento { get; set; }
        public string DescripcionPago { get; set; }
        public int? FechaEmision { get; set; }
        public string NombreApellido { get; set; }
        public decimal? MontoSinImpuesto { get; set; }
        public decimal? Iva { get; set; }
        public int? CodConcepto { get; set; }
        public string RucDeclara { get; set; }
        public int? Periodo { get; set; }
        public int? CodigoRenta { get; set; }
        public decimal? NumResolucion { get; set; }
        public DateTime? FechaProceso { get; set; }
        public int? CodigoRentaTrans { get; set; }
        public int? Estado { get; set; }
        public int? TipoProceso { get; set; }
        public int? Formulario { get; set; }
    }
}
