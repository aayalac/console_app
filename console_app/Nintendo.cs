﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Nintendo : Consola
    {
      public Nintendo(int pAño, string pFabricante, string pModelo, int pArquitectura) : base(pAño, pFabricante, pModelo, pArquitectura)
        {
        }
    }
}
