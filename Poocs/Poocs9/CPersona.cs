using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs9
{
    class CPersona
    {
        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Constructor de Persona");
            nombre = pNombre;
            edad = pEdad;
        }

        private string nombre;
        private int edad;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Edad
        {
            set
            {
                if (value >= 18)
                    edad = value;
                else
                {
                    edad = -1;
                    Console.WriteLine("Edad no permitida");
                }
            }
            get { return edad; }
        }

        public void Muestra()
        {
            Console.WriteLine("{0} tiene {1} años", nombre, edad );
        }
    }
}
