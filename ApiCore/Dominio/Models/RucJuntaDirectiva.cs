using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Models
{
    public class RucJuntaDirectiva
    {
        [Key]
        public int IdJunta { get; set; }
        public int IdNit { get; set; }
        public Nullable<System.DateTime> FechaInicioJunta { get; set; }
        public Nullable<System.DateTime> FechaFinJunta { get; set; }
        public int EstadoJunta { get; set; }
        public System.DateTime FechaProceso { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual Ruc Ruc { get; set; }
    }
}
