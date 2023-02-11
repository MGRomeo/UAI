using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intregrador_1
{
    internal class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Axo { get; set; }
        public decimal Precio { get; set; }

        public Persona Duenio()
        {
            return duenio;
        }

        //Falta finalizador.Que cuando el objeto queda liberado muestre una leyenda indicando la
        //Patente del Auto.
    }
}
