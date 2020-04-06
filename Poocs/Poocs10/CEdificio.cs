using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs10
{
    class CEdificio
    {
        private string direccion;
        private int CantDepartamentos;
        private int DepRentados;

        public CEdificio(string pDireccion, int pCantidad, int pRentados)
        {
            direccion = pDireccion;
            CantDepartamentos = pCantidad;
            DepRentados = pRentados;
        }

        public void Muestra()
        {
            Console.WriteLine("Edificio en {0} con {1} departamentos, {2} rentados", direccion, CantDepartamentos, DepRentados);
        }
    }
}
