using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Consola
    {
        public int _Año;
        public string _Fabricante;
        public string _Modelo;
        public int _Arquitectura;

        public int Año
        {
            get { return _Año; }
            set {_Año = value;}
        }
        public string Fabricante
        {
            get {return _Fabricante;}
            set {_Fabricante = value;}
        }
        public string Modelo
        {
            get {return _Modelo;}
            set {_Modelo = value;}
        }
        public int Arquitectura
        {
            get { return _Arquitectura;}
            set { _Arquitectura = value;}
        }
        public Consola(int pAño, string pFabricante, string pModelo, int pArquitectura )
        {
            Año = pAño;
            Fabricante = pFabricante;
            Modelo = pModelo;
            Arquitectura = pArquitectura;            
        }
    }
}