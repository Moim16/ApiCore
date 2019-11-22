using ApiCore.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Servicios
{
   public interface ITodoRucContribuyente
    {
        Task<IEnumerable<ActividadEconomicaDto>> ListAsyncActividadEconomica();
        Task<ActividadEconomicaDto> FindByIdAsyncActividadEconomica(int id);

        Task<IEnumerable<RentaDto>> ListAsyncRenta();
        Task<RentaDto> FindByIdAsyncRenta(int id);


        Task<IEnumerable<RucDto>> ListAsyncRuc();
        Task<RucDto> FindByIdAsyncRuc(int idnit);

        Task<IEnumerable<RucCategoriaDto>> ListAsyncRucCategoria();
        Task<RucCategoriaDto> FindByIdAsyncRucCategoria(int idnit);
        Task<IEnumerable<RucCertificacionDto>> ListAsyncRucCertificacion();
        Task<RucCertificacionDto> FindByIdAsyncRucCertificacion(int idnit);


        Task<IEnumerable<RucCiiuDto>> ListAsyncRucCiiu();
        Task<RucCiiuDto> FindByIdAsyncRucCiiu(int idnit);

        Task<IEnumerable<RucEmbajadorDto>> ListAsyncRucEmbajador();
        Task<RucEmbajadorDto> FindByIdAsyncRucEmbajador(int idnit);

        Task<IEnumerable<RucEmpleadorDto>> ListAsyncRucEmpleador();
        Task<RucEmpleadorDto> FindByIdAsyncRucEmpleador(int idnit);

        Task<IEnumerable<RucInformacionFinancieraDto>> ListAsyncRucInformacionFinanciera();
        Task<RucInformacionFinancieraDto> FindByIdAsyncRucInformacionFinanciera(int idnit);


        Task<IEnumerable<RucInformacionSocioDto>> ListAsyncRucInformacionSocio();
        Task<RucInformacionSocioDto> FindByIdAsyncRucInformacionSocio(int idnit);

        Task<IEnumerable<RucJuntaDirectivaDto>> ListAsyncRucJuntaDirectiva();
        Task<RucJuntaDirectivaDto> FindByIdAsyncRucJuntaDirectiva(int idnit);

        Task<IEnumerable<RucJuridicaDto>> ListAsyncRucRucJuridica();
        Task<RucJuridicaDto> FindByIdAsyncRucJuridica(int idnit);

        Task<IEnumerable<RucNaturalDto>> ListAsyncRucRucNatural();
        Task<RucNaturalDto> FindByIdAsyncRucNatural(int idnit);

        Task<IEnumerable<RucObligacionDto>> ListAsyncRucObligacion();
        Task<RucObligacionDto> FindByIdAsyncRucObligacion(int idnit);
    }
}
