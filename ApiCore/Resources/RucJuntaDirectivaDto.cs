using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucJuntaDirectivaDto
    {
        public int IdJunta { get; set; }
        public int IdNit { get; set; }
        public Nullable<System.DateTime> FechaInicioJunta { get; set; }
        public Nullable<System.DateTime> FechaFinJunta { get; set; }
        public int EstadoJunta { get; set; }
        public System.DateTime FechaProceso { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual RucDto RucDto { get; set; }
    }
}
