using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos Instancias
            CCalculadora calcu1 = new CCalculadora();

            //Accedemos alos atributos para colocar la informacion
            calcu1.a = 5;
            calcu1.b = 3;

            //Mostrar Valores
            calcu1.Muestra();

            //Suma 
            calcu1.Suma();

            //Mostrar Valores
            calcu1.Muestra();

            //---
            Console.WriteLine("-----------");

            //Nuevo Objeto
            CCalculadora calcu2 = new CCalculadora();
            calcu2.a = 23;
            calcu2.b = 54;
            calcu2.Suma();

            calcu1.Muestra();
            calcu2.Muestra();
        }
    }
}
