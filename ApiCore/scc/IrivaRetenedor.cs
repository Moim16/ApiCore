using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class IrivaRetenedor
    {
        public long IdDetalle { get; set; }
        public decimal? IngresosBrutos { get; set; }
        public decimal? ValorCotizacion { get; set; }
        public decimal? BaseImponible { get; set; }
        public decimal? ValorRetenido { get; set; }
        public int? CodigoRenglonRetenido { get; set; }
        public decimal? ValorSinImpuesto { get; set; }
        public decimal? Iva { get; set; }
        public int? Periodo { get; set; }
        public string Ruc { get; set; }
        public string CodRenglonIvaCreditoFiscal { get; set; }
        public int? Tabla { get; set; }
    }
}
