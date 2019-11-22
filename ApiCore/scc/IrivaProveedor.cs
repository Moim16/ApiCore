using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class IrivaProveedor
    {
        public long IdDetalle { get; set; }
        public decimal? IngresosBrutos { get; set; }
        public decimal? MontoInss { get; set; }
        public decimal? BaseImponible { get; set; }
        public decimal? ValorRetenido { get; set; }
        public decimal? ValorSinImpuesto { get; set; }
        public decimal? AlicuotaDeRetencion { get; set; }
        public decimal? Iva { get; set; }
        public string Ruc { get; set; }
        public string Periodo { get; set; }
        public int? CodConcepto { get; set; }
        public int? CodRetenc { get; set; }
        public int? Tabla { get; set; }
    }
}
