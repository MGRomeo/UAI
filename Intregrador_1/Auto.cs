using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intregrador_1
{
    public class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public decimal Precio { get; set; }
        public Boolean TieneDuenio { get; set; }
        public Persona Persona { get; set; }

        public Auto(string pPatente, string pMarca, string pModelo, string pAxo, decimal pPrecio, bool pTieneDuenio = false)
        {
            Patente = pPatente; Marca = pMarca; Modelo = pModelo; Año = pAxo; Precio = pPrecio;
            TieneDuenio = pTieneDuenio;
        }

        public bool Dueño()
        {
            if (TieneDuenio == true)
            {
                MessageBox.Show("El auto ya posee dueño", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else return false;
        }

        public void AsignarDueño(Persona persona)
        {
            TieneDuenio = true;
            Persona = persona;
        }

        ~Auto()
        {
            MessageBox.Show($"Se ejecuta DESTRUCTOR, se finaliza el ciclo de vida del Auto:{Environment.NewLine}" +
                            $"Modelo: {Modelo}{Environment.NewLine}" +
                            $"Marca {Marca},{Environment.NewLine}" +
                            $"Patente: {Patente}","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
