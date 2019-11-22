using ApiCore.Dominio.Models;
using ApiCore.Dominio.Repositorio;
using ApiCore.Persistence.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Persistence.Repositorio
{
    public class ContribuyenteRepository : BaseMysqlRepositorio, ITodoRucRepository
    {

        public ContribuyenteRepository(ContribuyenteContexto context) : base(context)
        {

        }
        public async Task<ActividadEconomica> FindByIdAsyncActividadEconomica(int id)
        {
           return await _context.ActividadEconomica.FindAsync(id);
        }

        public async Task<Renta> FindByIdAsyncRenta(int id)
        {

            return await _context.Renta.FindAsync(id);
        }

        public async Task<Ruc> FindByIdAsyncRuc(int idnit)
        {
            //return await _context.Ruc.Include(x => x.RucCategorias).Where(x=>x.IdNit.Equals(idnit)).FirstOrDefaultAsync();
            return await _context.Ruc.FindAsync(idnit);
        }

        public async Task<RucCategoria> FindByIdAsyncRucCategoria(int idnit)
        {
            return await _context.RucCategoria.FindAsync(idnit);
        }

        public async Task<RucCertificacion> FindByIdAsyncRucCertificacion(int idnit)
        {
            return await _context.RucCertificacion.FindAsync(idnit);
        }

        public async Task<RucCiiu> FindByIdAsyncRucCiiu(int idnit)
        {
            return await _context.RucCiiu.FindAsync(idnit);
        }

        public async Task<RucEmbajador> FindByIdAsyncRucEmbajador(int idnit)
        {
            return await _context.RucEmbajador.FindAsync(idnit);
        }

        public async Task<RucEmpleador> FindByIdAsyncRucEmpleador(int idnit)
        {
            return await _context.RucEmpleador.FindAsync(idnit);
        }

        public async Task<RucInformacionFinanciera> FindByIdAsyncRucInformacionFinanciera(int idnit)
        {
            return await _context.RucInformacionFinanciera.FindAsync(idnit);
        }

        public async Task<RucInformacionSocio> FindByIdAsyncRucInformacionSocio(int idnit)
        {
            return await _context.RucInformacionSocio.FindAsync(idnit);
        }

        public async Task<RucJuntaDirectiva> FindByIdAsyncRucJuntaDirectiva(int idnit)
        {
            return await _context.RucJuntaDirectiva.FindAsync(idnit);
        }

        public async Task<RucJuridica> FindByIdAsyncRucJuridica(int idnit)
        {
            return await _context.RucJuridica.FindAsync(idnit);
        }

        public async Task<RucNatural> FindByIdAsyncRucNatural(int idnit)
        {
            return await _context.RucNatural.FindAsync(idnit);
        }

        public async  Task<RucObligacion> FindByIdAsyncRucObligacion(int idnit)
        {
            return await _context.RucObligacion.FindAsync(idnit);
        }

        public async Task<IEnumerable<ActividadEconomica>> ListAsyncActividadEconomica()
        {
            return await _context.ActividadEconomica.ToListAsync();
        }

        public async Task<IEnumerable<Renta>> ListAsyncRenta()
        {
            return await _context.Renta.ToListAsync();
        }

        public async Task<IEnumerable<Ruc>> ListAsyncRuc()
        {
            return await _context.Ruc.ToListAsync();
        }

        public async Task<IEnumerable<RucCategoria>> ListAsyncRucCategoria()
        {
            return await _context.RucCategoria.ToListAsync();
        }

        public async Task<IEnumerable<RucCertificacion>> ListAsyncRucCertificacion()
        {
            return await _context.RucCertificacion.ToListAsync();
        }

        public async Task<IEnumerable<RucCiiu>> ListAsyncRucCiiu()
        {
            return await _context.RucCiiu.ToListAsync();
        }

        public async Task<IEnumerable<RucEmbajador>> ListAsyncRucEmbajador()
        {
            return await _context.RucEmbajador.ToListAsync();
        }

        public async Task<IEnumerable<RucEmpleador>> ListAsyncRucEmpleador()
        {
            return await _context.RucEmpleador.ToListAsync();
        }

        public async Task<IEnumerable<RucInformacionFinanciera>> ListAsyncRucInformacionFinanciera()
        {
            return await _context.RucInformacionFinanciera.ToListAsync();
        }

        public async Task<IEnumerable<RucInformacionSocio>> ListAsyncRucInformacionSocio()
        {
            return await _context.RucInformacionSocio.ToListAsync();
        }

        public async Task<IEnumerable<RucJuntaDirectiva>> ListAsyncRucJuntaDirectiva()
        {
            return await _context.RucJuntaDirectiva.ToListAsync();
        }

        public async Task<IEnumerable<RucObligacion>> ListAsyncRucObligacion()
        {
            return await _context.RucObligacion.ToListAsync();
        }

        public async Task<IEnumerable<RucJuridica>> ListAsyncRucRucJuridica()
        {
            return await _context.RucJuridica.ToListAsync();
        }

        public async Task<IEnumerable<RucNatural>> ListAsyncRucRucNatural()
        {
            return await _context.RucNatural.ToListAsync();
        }
    }
}
