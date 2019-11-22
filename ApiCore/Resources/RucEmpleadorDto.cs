using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucEmpleadorDto
    {
        public int id { get; set; }
        public int IdEmpleado { get; set; }
        public int IdEmpleador { get; set; }
        public int TipoRegistro { get; set; }
        public int Estado { get; set; }
        public System.DateTime FechaProceso { get; set; }
        public string Usuario { get; set; }

        public virtual RucDto RucDto { get; set; }
    }
}
