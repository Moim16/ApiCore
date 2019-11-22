using System;
using System.Collections.Generic;

namespace ApiCore.sit
{
    public partial class Controlenvios
    {
        public uint Id { get; set; }
        public uint Idretenedor { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fechaenviada { get; set; }

        public virtual Retenedores IdretenedorNavigation { get; set; }
    }
}
