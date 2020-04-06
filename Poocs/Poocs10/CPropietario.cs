﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs10
{
    class CPropietario
    {
        private string nombre;
        private CEdificio propiedad = null;

        public CPropietario(string pNombre)
        {
            nombre = pNombre;
        }

        public void MostrarPropiedad()
        {
            if (propiedad != null)
            {
                Console.Write("{0} tiene", nombre);
                propiedad.Muestra();
            }
            else
                Console.WriteLine("{0} aun no tiene propiedades" , nombre);
        }

        public void AdicionaPropiedad(CEdificio pEdificio)
        {
            if (pEdificio != null)
                propiedad = pEdificio;
        }
    }
}
