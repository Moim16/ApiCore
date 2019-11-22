using ApiCore.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Repositorio
{
   public interface ITodoRucRepository
    {
        Task<IEnumerable<ActividadEconomica>> ListAsyncActividadEconomica();  
        Task<ActividadEconomica> FindByIdAsyncActividadEconomica(int id);

        Task<IEnumerable<Renta>> ListAsyncRenta();
        Task<Renta> FindByIdAsyncRenta(int id);


        Task<IEnumerable<Ruc>> ListAsyncRuc();
        Task<Ruc> FindByIdAsyncRuc(int idnit);

        Task<IEnumerable<RucCategoria>> ListAsyncRucCategoria();
        Task<RucCategoria> FindByIdAsyncRucCategoria(int idnit);
        Task<IEnumerable<RucCertificacion>> ListAsyncRucCertificacion();
        Task<RucCertificacion> FindByIdAsyncRucCertificacion(int idnit);


        Task<IEnumerable<RucCiiu>> ListAsyncRucCiiu();
        Task<RucCiiu> FindByIdAsyncRucCiiu(int idnit);

        Task<IEnumerable<RucEmbajador>> ListAsyncRucEmbajador();
        Task<RucEmbajador> FindByIdAsyncRucEmbajador(int idnit);

        Task<IEnumerable<RucEmpleador>> ListAsyncRucEmpleador();
        Task<RucEmpleador> FindByIdAsyncRucEmpleador(int idnit);

        Task<IEnumerable<RucInformacionFinanciera>> ListAsyncRucInformacionFinanciera();
        Task<RucInformacionFinanciera> FindByIdAsyncRucInformacionFinanciera(int idnit);


        Task<IEnumerable<RucInformacionSocio>> ListAsyncRucInformacionSocio();
        Task<RucInformacionSocio> FindByIdAsyncRucInformacionSocio(int idnit);

        Task<IEnumerable<RucJuntaDirectiva>> ListAsyncRucJuntaDirectiva();
        Task<RucJuntaDirectiva> FindByIdAsyncRucJuntaDirectiva(int idnit);

        Task<IEnumerable<RucJuridica>> ListAsyncRucRucJuridica();
        Task<RucJuridica> FindByIdAsyncRucJuridica(int idnit);

        Task<IEnumerable<RucNatural>> ListAsyncRucRucNatural();
        Task<RucNatural> FindByIdAsyncRucNatural(int idnit);

        Task<IEnumerable<RucObligacion>> ListAsyncRucObligacion();
        Task<RucObligacion> FindByIdAsyncRucObligacion(int idnit);



    }
}
