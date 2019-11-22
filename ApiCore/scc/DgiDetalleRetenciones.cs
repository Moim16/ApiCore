using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class DgiDetalleRetenciones
    {
        public long IdDetalle { get; set; }
        public string RucRetenido { get; set; }
        public int? Periodo { get; set; }
        public int? CodConcepto { get; set; }
        public string NombreApellido { get; set; }
        public decimal? IngresosBrutos { get; set; }
        public decimal? MontoRetenido { get; set; }
        public DateTime? FechaProceso { get; set; }
        public int? CodigoRenta { get; set; }
        public int? CodigoRentaTrans { get; set; }
        public int? Estado { get; set; }
        public int? TipoProceso { get; set; }
        public decimal? MontoInss { get; set; }
        public decimal? MontoPension { get; set; }
        public decimal? BaseImponible { get; set; }
        public int? Alicuota { get; set; }
        public string RucDeclara { get; set; }
        public int? Formulario { get; set; }
        public long? NumResolucion { get; set; }
    }
}
