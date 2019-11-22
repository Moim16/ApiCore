using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Resources
{
    public class RucJuridicaDto
    {
        public int IdNit { get; set; }
        public string RazonSocial { get; set; }
        public Nullable<System.DateTime> FechaConstitucion { get; set; }
        public Nullable<System.DateTime> FechaLiquidacion { get; set; }
        public int ClaseSociedad { get; set; }
        public Nullable<int> IdTipoPersona { get; set; }
        public string DocCreaPersona { get; set; }
        public int TipoOrganizacion { get; set; }
        public string AbrevRazonSocial { get; set; }
        public string NombreNotario { get; set; }
        public string PrimerApellidoNotario { get; set; }
        public string SegundoApellidoNotario { get; set; }
        public Nullable<int> Carnet { get; set; }
        public string Usuario { get; set; }
        public Nullable<System.DateTime> FechaProces { get; set; }

        public virtual RucDto RucDto { get; set; }
    }
}
