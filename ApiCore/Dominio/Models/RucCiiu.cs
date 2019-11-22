using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Models
{
    public class RucCiiu
    {
        [Key]
        public int Id { get; set; }
        public int IdNit { get; set; }
        public int CodigoActividadEconomica { get; set; }
        public string TipoActividad { get; set; }
        public int EstadoActividad { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual Ruc Ruc { get; set; }
        public virtual ActividadEconomica ActividadEconomica { get; set; }
    }
}
