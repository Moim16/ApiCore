using ApiCore.Dominio.Models;
using ApiCore.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Mapping
{
    public class ResourceToModelProfile :Profile
    {
        public ResourceToModelProfile()
        {
            


            CreateMap<ActividadEconomicaDto, ActividadEconomica>();
            CreateMap<RentaDto, Renta>();
            CreateMap<RucDto, Ruc>();
            CreateMap<RucCategoriaDto, RucCategoria>();
            CreateMap<RucCertificacionDto, RucCertificacion>();
            CreateMap<RucCiiuDto, RucCiiu>();
            CreateMap<RucEmbajadorDto, RucEmbajador>();
            CreateMap<RucEmpleadorDto, RucEmpleador>();
            CreateMap<RucInformacionFinancieraDto, RucInformacionFinanciera>();
            CreateMap<RucInformacionSocioDto, RucInformacionSocio>();
            CreateMap<RucJuntaDirectivaDto, RucJuntaDirectiva>();
            CreateMap<RucJuridicaDto, RucJuridica>();
            CreateMap<RucNaturalDto, RucNatural>();
            CreateMap<RucObligacionDto, RucObligacion>();
        }
    }
}
