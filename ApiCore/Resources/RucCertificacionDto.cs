using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucCertificacionDto
    {
        public int IdCertificacion { get; set; }
        public int IdNit { get; set; }
        public Nullable<System.DateTime> FechaCertificacion { get; set; }
        public string RegCertificacion { get; set; }
        public string LibroDiario { get; set; }
        public string LibroSociedad { get; set; }
        public string LibroPersona { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual RucDto RucDto { get; set; }
    }
}
