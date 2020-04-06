using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs11
{
    class Program
    {
        static void Main(string[] args)
        {
            CProducto uno = new CProducto("Audi", 45000);
            uno.CalculaPrecio();
            uno.MuestraVenta();
            Console.WriteLine("===========================");

            CProductoImportado dos = new CProductoImportado("Bmw", 45000, 0.15);
            dos.CalculaPrecio();
            dos.MuestraVenta();
            Console.WriteLine("===========================");

            CProductoDetenido tres = new CProductoDetenido("Mercedes Benz", 45000, 0.30, 20000);
            tres.CalculaPrecio();
            tres.MuestraVenta();
            Console.WriteLine("===========================");

        }
    }
}
