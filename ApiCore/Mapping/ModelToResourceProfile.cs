using ApiCore.Dominio.Models;
using ApiCore.Extensions;
using ApiCore.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {

            CreateMap<ActividadEconomica, ActividadEconomicaDto>();
            CreateMap<Renta, RentaDto>();

            #region Ruc - RucDto
            var MappingRuc = CreateMap<Ruc, RucDto>();
           // MappingRuc.ForMember(x => x.RucCategoriasDto, c => c.MapFrom(x => x.RucCategorias));

            #endregion

            CreateMap<RucCategoria, RucCategoriaDto>();
            CreateMap<RucCertificacion, RucCertificacionDto>();
            CreateMap<RucCiiu, RucCiiuDto>();
            CreateMap<RucEmbajador, RucEmbajadorDto>();
            CreateMap<RucEmpleador, RucEmpleadorDto>();
            CreateMap<RucInformacionFinanciera, RucInformacionFinancieraDto>();
            CreateMap<RucInformacionSocio, RucInformacionSocioDto>();
            CreateMap<RucJuntaDirectiva, RucJuntaDirectivaDto>();
            CreateMap<RucJuridica, RucJuridicaDto>();
            CreateMap<RucNatural, RucNaturalDto>();
            CreateMap<RucObligacion, RucObligacionDto>();

        }
    }
}
