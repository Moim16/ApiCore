using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Entidad { get; set; }        
        public string Contrasenia { get; set; }
        public string Token { get; set; }
    }
}
