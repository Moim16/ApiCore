using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class TipoCambios
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Tipocambio { get; set; }
    }
}
