using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intregrador_1
{
    internal class Auto
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Axo { get; set; }
        public decimal Precio { get; set; }
        public Boolean TieneDuenio { get; set; }


        public Auto(string pPatente, string pMarca, string pModelo, string pAxo, decimal pPrecio, bool pTieneDuenio = false)
        {
            Patente = pPatente; Marca = pMarca; Modelo = pModelo; Axo = pAxo; Precio = pPrecio;
            TieneDuenio = pTieneDuenio;
        }

        public bool TieneDueño(Auto pAuto)
        {
            if (pAuto.TieneDuenio == true) return true;
            else return false;
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
