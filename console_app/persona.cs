using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class persona : entidad
    {
        public string FirstName { get; private set; }

        public persona (string name, string primer_nombre): base(name)
        {
            FirstName = primer_nombre;
        }
    }
}
