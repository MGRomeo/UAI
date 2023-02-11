using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Intregrador_1
{
    internal class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Auto> Lista_de_Autos_por_persona = new List<Auto>();

        //Retorna la cantidad de autos que posee la persona
        public int Cantidad_de_Autos()
        {
            return 1;
        }
        public Persona(string pDni, string pNombre, string pApellido)
        {
            this.DNI = pDni; this.Nombre = pNombre; this.Apellido = pApellido;
        }
        
        public List<Auto> AgregarAuto(Auto pAuto)
        {
            Lista_de_Autos_por_persona.Add(pAuto);
            return Lista_de_Autos_por_persona;
        }

       // Falta finalizador.Que cuando el objeto queda liberado muestre una leyenda indicando el
       //DNI de la Persona.
    }
}
