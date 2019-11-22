using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class IrivaAutotraslacionRetenido
    {
        public long IdDetalle { get; set; }
        public string Ruc { get; set; }
        public decimal? IngresosBrutos { get; set; }
        public decimal? BaseImponible { get; set; }
        public decimal? ValorRetenido { get; set; }
        public int? CodRenglonRetenido { get; set; }
        public decimal? ValorSinImpuesto { get; set; }
        public decimal? ValorTrasladado { get; set; }
        public int? CodRenglonRengloIva { get; set; }
        public int? Periodo { get; set; }
    }
}
