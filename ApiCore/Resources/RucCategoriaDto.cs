using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucCategoriaDto
    {
        public int Id { get; set; }
        public int IdNit { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public int IdSubcategoria { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }
        public string Usuario { get; set; }

        public virtual RucDto RucDto { get; set; }
    }
}
