using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucCiiuDto
    {
        public int Id { get; set; }
        public int IdNit { get; set; }
        public int CodigoActividadEconomica { get; set; }
        public string TipoActividad { get; set; }
        public int EstadoActividad { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual RucDto RucDto { get; set; }
        public virtual ActividadEconomicaDto ActividadEconomicaDto { get; set; }
    }
}
