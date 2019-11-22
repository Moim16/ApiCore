using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Repositorio
{
   public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
