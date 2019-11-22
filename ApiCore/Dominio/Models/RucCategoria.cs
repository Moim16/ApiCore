using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Models
{
    public class RucCategoria
    {
        [Key]
        public int Id { get; set; }
        public int IdNit { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public int IdSubcategoria { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }
        public string Usuario { get; set; }

        public virtual Ruc Ruc { get; set; }
    }
}
