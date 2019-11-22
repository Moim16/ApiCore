﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Models
{
    public class RucEmbajador
    {
        [Key]
        public int Id { get; set; }
        public string RucEmbajada { get; set; }
        public string RucEmbajador1 { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<System.DateTime> FechaProceso { get; set; }
        public string Usuario { get; set; }
        public Nullable<int> TipoPersona { get; set; }
    }
}
