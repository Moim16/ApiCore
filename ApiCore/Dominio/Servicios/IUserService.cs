using ApiCore.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Servicios
{
   public interface IUserService
    {
        User Authenticate(string username, string password);
    }
}
