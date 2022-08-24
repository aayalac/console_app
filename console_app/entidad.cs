using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class entidad
    {
        public string Name { get; protected set; }

        protected entidad(string Name)
        {
            this.Name = Name;
        }
    }
}
