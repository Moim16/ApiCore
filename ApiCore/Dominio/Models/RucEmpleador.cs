using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Models
{
    public class RucEmpleador
    {
        [Key]
        public int id { get; set; }
        public int IdEmpleado { get; set; }
        public int IdEmpleador { get; set; }
        public int TipoRegistro { get; set; }
        public int Estado { get; set; }
        public System.DateTime FechaProceso { get; set; }
        public string Usuario { get; set; }

        public virtual Ruc Ruc { get; set; }
    }
}
