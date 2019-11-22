using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RentaDto
    {
        public RentaDto()
        {
            this.RucDto = new HashSet<RucDto>();
            this.RucInformacionFinancieraDto = new HashSet<RucInformacionFinancieraDto>();
            this.RucInformacionSocioDto = new HashSet<RucInformacionSocioDto>();
            this.RucObligacionDto = new HashSet<RucObligacionDto>();
        }


        public int CodigoRenta { get; set; }
        public string DescripcionRenta { get; set; }
        public int AdministraContribuyentes { get; set; }
        public Nullable<int> CodigoDepartamento { get; set; }
        public Nullable<int> CodAgenciaFisSIT { get; set; }
        public Nullable<int> RentaAdscrita { get; set; }

        public virtual ICollection<RucDto> RucDto { get; set; }
        public virtual ICollection<RucInformacionFinancieraDto> RucInformacionFinancieraDto { get; set; }
        public virtual ICollection<RucInformacionSocioDto> RucInformacionSocioDto { get; set; }
        public virtual ICollection<RucObligacionDto> RucObligacionDto { get; set; }
    }
}
