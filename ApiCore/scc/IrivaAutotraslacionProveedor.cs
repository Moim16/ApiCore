using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class IrivaAutotraslacionProveedor
    {
        public long IdDetalle { get; set; }
        public int? Periodo { get; set; }
        public decimal? MontoSinImpuesto { get; set; }
        public decimal? ValorRetenido { get; set; }
        public decimal? MontoIvaAutotrasladado { get; set; }
        public string Ruc { get; set; }
    }
}
