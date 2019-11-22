using System;
using System.Collections.Generic;

namespace ApiCore.sit
{
    public partial class Traslados
    {
        public uint Id { get; set; }
        public uint? Periodo { get; set; }
        public uint? CantidadRegistros { get; set; }
        public DateTime FechaTraslado { get; set; }
        public string Usuario { get; set; }
        public string Rucretenedor { get; set; }
    }
}
