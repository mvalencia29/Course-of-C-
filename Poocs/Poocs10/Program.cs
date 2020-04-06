using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs10
{
    class Program
    {
        static void Main(string[] args)
        {
            CPropietario Miguel = new CPropietario("Miguel");
            CEdificio edif1 = new CEdificio("Tranv. 88 #19a - 60", 12, 4);

            //Miguel.MostrarPropiedad();
            Miguel.AdicionaPropiedad(edif1);
            Miguel.MostrarPropiedad();

        }
    }
}
