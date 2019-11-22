using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class DgaImportadores
    {
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string Serie { get; set; }
        public long? Declaracion { get; set; }
        public string DescMercaderia { get; set; }
        public decimal? CantItem { get; set; }
        public double? ValorFob { get; set; }
        public double? ValorSeguro { get; set; }
        public double? ValorFlete { get; set; }
        public double? ValorOtros { get; set; }
        public double? ValorCif { get; set; }
        public int? FechaLiquida { get; set; }
        public double? TipoCambio { get; set; }
        public double? LiqIva { get; set; }
        public double? ExoIva { get; set; }
        public double? PagIva { get; set; }
        public double? LiqIsc { get; set; }
        public double? ExoIsc { get; set; }
        public double? PagIsc { get; set; }
        public double? LiqDai { get; set; }
        public double? ExoDai { get; set; }
        public double? PagDai { get; set; }
        public double? LiqIso { get; set; }
        public double? ExoIso { get; set; }
        public double? PagIso { get; set; }
        public int? FechaCarga { get; set; }
        public int? Periodo { get; set; }
        public int Pkclave { get; set; }
        public int? TipoDeclar { get; set; }
    }
}
