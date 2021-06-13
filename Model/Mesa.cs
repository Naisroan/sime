using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sime.Model
{
    public class Mesa
    {
        public int IdMesa { get; set; }

        public string Nombre { get; set; }

        public int CantidadSillas { get; set; }

        public bool Ocupada { get; set; }

        public bool Activa { get; set; }
    }
}
