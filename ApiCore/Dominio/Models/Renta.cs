using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Dominio.Models
{
    public class Renta
    {
        public Renta()
        {
            this.Rucs = new HashSet<Ruc>();
            this.RucInformacionFinancieras = new HashSet<RucInformacionFinanciera>();
            this.RucInformacionSocios = new HashSet<RucInformacionSocio>();
            this.RucObligacions = new HashSet<RucObligacion>();
        }

        [Key]
        public int CodigoRenta { get; set; }
        public string DescripcionRenta { get; set; }
        public int AdministraContribuyentes { get; set; }
        public Nullable<int> CodigoDepartamento { get; set; }
        public Nullable<int> CodAgenciaFisSIT { get; set; }
        public Nullable<int> RentaAdscrita { get; set; }

        public virtual ICollection<Ruc> Rucs { get; set; }
        public virtual ICollection<RucInformacionFinanciera> RucInformacionFinancieras { get; set; }
        public virtual ICollection<RucInformacionSocio> RucInformacionSocios { get; set; }
        public virtual ICollection<RucObligacion> RucObligacions { get; set; }
       
    }
}
