using System;
using System.Collections.Generic;

namespace ApiCore.scc
{
    public partial class CategorizadoMorosof
    {
        public int IdC { get; set; }
        public int IdNit { get; set; }
        public string Nit { get; set; }
        public string NombreRazon { get; set; }
        public int CodigoRenta { get; set; }
        public string DescripcionRenta { get; set; }
        public string CodImpuesto { get; set; }
        public int? Periodo { get; set; }
        public int CodigoSubcategoria { get; set; }
        public string DescripcionSubcategoria { get; set; }
        public int? NumeroTelefonoR { get; set; }
        public int? NumeroTelefono1 { get; set; }
        public int? NumeroTelefono2 { get; set; }
        public double? ValorImpuesto { get; set; }
        public double? ValorMantenimiento { get; set; }
        public double? ValorMulta { get; set; }
        public double? ValorRecargo { get; set; }
        public double? Total { get; set; }
        public int? Celular { get; set; }
        public string Telefonica { get; set; }
    }
}
