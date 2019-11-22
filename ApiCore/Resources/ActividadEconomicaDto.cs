using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class ActividadEconomicaDto
    {
        public ActividadEconomicaDto()
        {
            this.RucCiiuDto = new HashSet<RucCiiuDto>();
        }

        [Key]
        public int CodigoActividadEconomica { get; set; }
        public int CodigoClase { get; set; }
        public string DescripcionActividadEconomica { get; set; }
        public int EstadoActividadEconomica { get; set; }
        public int TipoGrupoActividad { get; set; }

        public virtual ICollection<RucCiiuDto> RucCiiuDto { get; set; }
    }
}
