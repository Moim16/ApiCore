using ApiCore.Persistence.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Persistence.Repositorio
{
    public abstract class BaseMysqlRepositorio
    {
        protected readonly ContribuyenteContexto _context;
        public BaseMysqlRepositorio(ContribuyenteContexto context)
        {
            _context = context;
        }
    }
}
