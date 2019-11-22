using System;
using System.Collections.Generic;

namespace ApiCore.sit
{
    public partial class Retenedores
    {
        public Retenedores()
        {
            Controlenvios = new HashSet<Controlenvios>();
        }

        public uint Id { get; set; }
        public string Rucretenedor { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Controlenvios> Controlenvios { get; set; }
    }
}
