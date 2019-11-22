using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class CatastroPropCompra
    {
        public long IdDetalle { get; set; }
        public string NombresProp { get; set; }
        public string RazonSocialProp { get; set; }
        public string Ruc { get; set; }
        public decimal? ValorEnajDeclarado { get; set; }
        public decimal? ValorCatastral { get; set; }
        public decimal? ValorPagar { get; set; }
        public string NombreComprador { get; set; }
        public string RazonSocialComp { get; set; }
        public string IdentificacionComp { get; set; }
        public string NombresApellidosTram { get; set; }
        public DateTime? FechaProceso { get; set; }
        public DateTime? FechaInscripcionAvaluo { get; set; }
    }
}
