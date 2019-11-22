using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class CatastroCompradorInmuebles
    {
        public long IdDetalle { get; set; }
        public string Ruc { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public decimal? ValorDeclarado { get; set; }
        public decimal? ValorCatastral { get; set; }
        public decimal? ValorPagar { get; set; }
        public int? Periodo { get; set; }
        public string FechaProceso { get; set; }
    }
}
