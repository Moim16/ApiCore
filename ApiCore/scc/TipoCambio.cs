using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class TipoCambio
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public double Tc { get; set; }
        public ulong Id { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaCarga { get; set; }
        public sbyte? Cargado { get; set; }
    }
}
