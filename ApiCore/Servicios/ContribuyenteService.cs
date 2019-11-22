using ApiCore.Dominio.Repositorio;
using ApiCore.Dominio.Servicios;
using ApiCore.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Servicios
{
    public class ContribuyenteService: ITodoRucContribuyente
    {
        private readonly ITodoRucRepository _todoRucRepository;
        private readonly IMapper _mapper;

        public ContribuyenteService(ITodoRucRepository todoRucRepository, IMapper mapper)
        {
            this._todoRucRepository = todoRucRepository;
            this._mapper = mapper;
        }

        public async Task<ActividadEconomicaDto> FindByIdAsyncActividadEconomica(int id)
        {
            var FindByIdAsyncActividadEconomica = await _todoRucRepository.FindByIdAsyncActividadEconomica(id);
            var FindByIdAsyncActividadEconomicadto = _mapper.Map<ActividadEconomicaDto>(FindByIdAsyncActividadEconomica);
            return FindByIdAsyncActividadEconomicadto;
        }

        public async Task<RentaDto> FindByIdAsyncRenta(int id)
        {



            var FindByIdAsyncRenta = await _todoRucRepository.FindByIdAsyncRenta(id);
            var FindByIdAsyncRentadto = _mapper.Map<RentaDto>(FindByIdAsyncRenta);
            return FindByIdAsyncRentadto;
        }

        public async Task<RucDto> FindByIdAsyncRuc(int idnit)
        {
            var FindByIdAsyncRuc = await _todoRucRepository.FindByIdAsyncRuc(idnit);
            var FindByIdAsyncRucdto = _mapper.Map<RucDto>(FindByIdAsyncRuc);
            return FindByIdAsyncRucdto;
        }

        public async Task<RucCategoriaDto> FindByIdAsyncRucCategoria(int idnit)
        {
            var FindByIdAsyncRucCategoria = await _todoRucRepository.FindByIdAsyncRucCategoria(idnit);
            var FindByIdAsyncRucCategoriadto = _mapper.Map<RucCategoriaDto>(FindByIdAsyncRucCategoria);
            return FindByIdAsyncRucCategoriadto;
        }

        public async Task<RucCertificacionDto> FindByIdAsyncRucCertificacion(int idnit)
        {
            var FindByIdAsyncRucCertificacion = await _todoRucRepository.FindByIdAsyncRucCertificacion(idnit);
            var FindByIdAsyncRucCertificaciondto = _mapper.Map<RucCertificacionDto>(FindByIdAsyncRucCertificacion);
            return FindByIdAsyncRucCertificaciondto;
        }

        public async Task<RucCiiuDto> FindByIdAsyncRucCiiu(int idnit)
        {
            var FindByIdAsyncRucCiiu = await _todoRucRepository.FindByIdAsyncRucCiiu(idnit);
            var FindByIdAsyncRucCiiudto = _mapper.Map<RucCiiuDto>(FindByIdAsyncRucCiiu);
            return FindByIdAsyncRucCiiudto;
        }

        public async Task<RucEmbajadorDto> FindByIdAsyncRucEmbajador(int idnit)
        {
            var FindByIdAsyncRucEmbajador = await _todoRucRepository.FindByIdAsyncRucEmbajador(idnit);
            var FindByIdAsyncRucEmbajadordto = _mapper.Map<RucEmbajadorDto>(FindByIdAsyncRucEmbajador);
            return FindByIdAsyncRucEmbajadordto;
        }

        public async Task<RucEmpleadorDto> FindByIdAsyncRucEmpleador(int idnit)
        {
            var FindByIdAsyncRucEmpleador = await _todoRucRepository.FindByIdAsyncRucEmpleador(idnit);
            var FindByIdAsyncRucEmpleadordto = _mapper.Map<RucEmpleadorDto>(FindByIdAsyncRucEmpleador);
            return FindByIdAsyncRucEmpleadordto;
        }

        public async Task<RucInformacionFinancieraDto> FindByIdAsyncRucInformacionFinanciera(int idnit)
        {
            var FindByIdAsyncRucInformacionFinanciera = await _todoRucRepository.FindByIdAsyncRucInformacionFinanciera(idnit);
            var FindByIdAsyncRucInformacionFinancieradto = _mapper.Map<RucInformacionFinancieraDto>(FindByIdAsyncRucInformacionFinanciera);
            return FindByIdAsyncRucInformacionFinancieradto;
        }

        public async Task<RucInformacionSocioDto> FindByIdAsyncRucInformacionSocio(int idnit)
        {
            var FindByIdAsyncRucInformacionSocio = await _todoRucRepository.FindByIdAsyncRucInformacionSocio(idnit);
            var FindByIdAsyncRucInformacionSociodto = _mapper.Map<RucInformacionSocioDto>(FindByIdAsyncRucInformacionSocio);
            return FindByIdAsyncRucInformacionSociodto;
        }

        public async Task<RucJuntaDirectivaDto> FindByIdAsyncRucJuntaDirectiva(int idnit)
        {
            var FindByIdAsyncRucJuntaDirectiva = await _todoRucRepository.FindByIdAsyncRucJuntaDirectiva(idnit);
            var FindByIdAsyncRucJuntaDirectivadto = _mapper.Map<RucJuntaDirectivaDto>(FindByIdAsyncRucJuntaDirectiva);
            return FindByIdAsyncRucJuntaDirectivadto;
        }

        public async Task<RucJuridicaDto> FindByIdAsyncRucJuridica(int idnit)
        {
            var FindByIdAsyncRucJuridica = await _todoRucRepository.FindByIdAsyncRucJuridica(idnit);
            var FindByIdAsyncRucJuridicadto = _mapper.Map<RucJuridicaDto>(FindByIdAsyncRucJuridica);
            return FindByIdAsyncRucJuridicadto;
        }

        public async Task<RucNaturalDto> FindByIdAsyncRucNatural(int idnit)
        {
            var FindByIdAsyncRucNatural = await _todoRucRepository.FindByIdAsyncRucNatural(idnit);
            var FindByIdAsyncRucNaturaldto = _mapper.Map<RucNaturalDto>(FindByIdAsyncRucNatural);
            return FindByIdAsyncRucNaturaldto;
        }

        public async Task<RucObligacionDto> FindByIdAsyncRucObligacion(int idnit)
        {
            var FindByIdAsyncRucObligacion = await _todoRucRepository.FindByIdAsyncRucObligacion(idnit);
            var FindByIdAsyncRucObligaciondto = _mapper.Map<RucObligacionDto>(FindByIdAsyncRucObligacion);
            return FindByIdAsyncRucObligaciondto;
        }

        public async Task<IEnumerable<ActividadEconomicaDto>> ListAsyncActividadEconomica()
        {
            var ListAsyncActividadEconomica = await _todoRucRepository.ListAsyncActividadEconomica();
            var ListAsyncActividadEconomicadto = _mapper.Map<IEnumerable<ActividadEconomicaDto>>(ListAsyncActividadEconomica);
            return ListAsyncActividadEconomicadto;
        }

        public async Task<IEnumerable<RentaDto>> ListAsyncRenta()
        {
            var ListAsyncRenta = await _todoRucRepository.ListAsyncRenta();
            var ListAsyncRentadto = _mapper.Map<IEnumerable<RentaDto>>(ListAsyncRenta);
            return ListAsyncRentadto;
        }

        public async Task<IEnumerable<RucDto>> ListAsyncRuc()
        {
            var ListAsyncRuc = await _todoRucRepository.ListAsyncRuc();
            var ListAsyncRucdto = _mapper.Map<IEnumerable<RucDto>>(ListAsyncRuc);
            return ListAsyncRucdto;
        }

        public async Task<IEnumerable<RucCategoriaDto>> ListAsyncRucCategoria()
        {
            var ListAsyncRucCategoria = await _todoRucRepository.ListAsyncRucCategoria();
            var ListAsyncRucCategoriadto = _mapper.Map<IEnumerable<RucCategoriaDto>>(ListAsyncRucCategoria);
            return ListAsyncRucCategoriadto;
        }

        public async Task<IEnumerable<RucCertificacionDto>> ListAsyncRucCertificacion()
        {
            var ListAsyncRucCertificacion = await _todoRucRepository.ListAsyncRucCertificacion();
            var ListAsyncRucCertificaciondto = _mapper.Map<IEnumerable<RucCertificacionDto>>(ListAsyncRucCertificacion);
            return ListAsyncRucCertificaciondto;
        }

        public async Task<IEnumerable<RucCiiuDto>> ListAsyncRucCiiu()
        {
            var ListAsyncRucCiiu = await _todoRucRepository.ListAsyncRucCiiu();
            var ListAsyncRucCiiudto = _mapper.Map<IEnumerable<RucCiiuDto>>(ListAsyncRucCiiu);
            return ListAsyncRucCiiudto;
        }

        public async Task<IEnumerable<RucEmbajadorDto>> ListAsyncRucEmbajador()
        {
            var ListAsyncRucEmbajador = await _todoRucRepository.ListAsyncRucEmbajador();
            var ListAsyncRucEmbajadordto = _mapper.Map<IEnumerable<RucEmbajadorDto>>(ListAsyncRucEmbajador);
            return ListAsyncRucEmbajadordto;
        }

        public async Task<IEnumerable<RucEmpleadorDto>> ListAsyncRucEmpleador()
        {
            var ListAsyncRucEmpleador = await _todoRucRepository.ListAsyncRucEmpleador();
            var ListAsyncRucEmpleadordto = _mapper.Map<IEnumerable<RucEmpleadorDto>>(ListAsyncRucEmpleador);
            return ListAsyncRucEmpleadordto;
        }

        public async Task<IEnumerable<RucInformacionFinancieraDto>> ListAsyncRucInformacionFinanciera()
        {
            var ListAsyncRucInformacionFinanciera = await _todoRucRepository.ListAsyncRucInformacionFinanciera();
            var ListAsyncRucInformacionFinancieradto = _mapper.Map<IEnumerable<RucInformacionFinancieraDto>>(ListAsyncRucInformacionFinanciera);
            return ListAsyncRucInformacionFinancieradto;
        }

        public async Task<IEnumerable<RucInformacionSocioDto>> ListAsyncRucInformacionSocio()
        {
            var ListAsyncRucInformacionSocio = await _todoRucRepository.ListAsyncRucInformacionSocio();
            var ListAsyncRucInformacionSociodto = _mapper.Map<IEnumerable<RucInformacionSocioDto>>(ListAsyncRucInformacionSocio);
            return ListAsyncRucInformacionSociodto;
        }

        public async Task<IEnumerable<RucJuntaDirectivaDto>> ListAsyncRucJuntaDirectiva()
        {
            var ListAsyncRucJuntaDirectiva = await _todoRucRepository.ListAsyncRucJuntaDirectiva();
            var ListAsyncRucJuntaDirectivadto = _mapper.Map<IEnumerable<RucJuntaDirectivaDto>>(ListAsyncRucJuntaDirectiva);
            return ListAsyncRucJuntaDirectivadto;
        }

        public async Task<IEnumerable<RucObligacionDto>> ListAsyncRucObligacion()
        {
            var ListAsyncRucObligacion = await _todoRucRepository.ListAsyncRucObligacion();
            var ListAsyncRucJuntaDirectivadto = _mapper.Map<IEnumerable<RucObligacionDto>>(ListAsyncRucObligacion);
            return ListAsyncRucJuntaDirectivadto;
        }

        public async Task<IEnumerable<RucJuridicaDto>> ListAsyncRucRucJuridica()
        {
            var ListAsyncRucRucJuridica = await _todoRucRepository.ListAsyncRucRucJuridica();
            var ListAsyncRucRucJuridicadto = _mapper.Map<IEnumerable<RucJuridicaDto>>(ListAsyncRucRucJuridica);
            return ListAsyncRucRucJuridicadto;
        }

        public async Task<IEnumerable<RucNaturalDto>> ListAsyncRucRucNatural()
        {
            var ListAsyncRucRucJuridica = await _todoRucRepository.ListAsyncRucRucNatural();
            var ListAsyncRucRucJuridicadto = _mapper.Map<IEnumerable<RucNaturalDto>>(ListAsyncRucRucJuridica);
            return ListAsyncRucRucJuridicadto;
        }
    }
}
