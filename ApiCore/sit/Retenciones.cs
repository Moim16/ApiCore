using System;
using System.Collections.Generic;

namespace ApiCore.sit
{
    public partial class Retenciones
    {
        public uint Id { get; set; }
        public string Rucretenedor { get; set; }
        public string Rucretenido { get; set; }
        public string Nombre { get; set; }
        public DateTime Fechapago { get; set; }
        public DateTime Fecharetencion { get; set; }
        public decimal Montototal { get; set; }
        public decimal Montoretenido { get; set; }
        public decimal Montocomision { get; set; }
        public byte Tipomoneda { get; set; }
        public string Periodo { get; set; }
        public DateTime Fecharecepcion { get; set; }
        public DateTime? Fechainicialtransaccion { get; set; }
        public DateTime? Fechafinaltransaccion { get; set; }
    }
}
