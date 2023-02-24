using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intregrador_1
{
    public partial class Ingreso_DatosAutos : Form
    {
        public Ingreso_DatosAutos()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPatente.Text == "" || txtMarca.Text == "" || txtModelo.Text == ""|| txtAño.Text == "" || txtPrecio.Text == "")
                {
                    throw new IngresoVacio();
                }
                else
                {
                    string patente = txtPatente.Text;
                    string marca = txtMarca.Text;
                    string modelo = txtModelo.Text;
                    string año = txtAño.Text;
                    int precio = int.Parse(txtPrecio.Text);
                    Auto auto = new Auto(patente, marca, modelo, año, precio);
                    Program.integrador.CargaDgvAutos(auto);
                    Close();
                }
            }
            catch (IngresoVacio) when (txtPatente.Text == "") { MessageBox.Show("Debe ingresar una Patente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPatente.Select(); }

            catch (IngresoVacio) when (txtMarca.Text == "") { MessageBox.Show("Debe ingresar una Marca", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMarca.Select(); }

            catch (IngresoVacio) when (txtModelo.Text == "") { MessageBox.Show("Debe ingresar un Modelo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtModelo.Select(); }

            catch (IngresoVacio) when (txtAño.Text == "") { MessageBox.Show("Debe ingresar un Año", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtAño.Select(); }

            catch (IngresoVacio) when (txtPrecio.Text == "") { MessageBox.Show("Debe ingresar un Precio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtPrecio.Select(); }

            catch (FormatException) { MessageBox.Show("Debe ingresar numero para el Precio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);txtPrecio.Select(); }
        }

        public class IngresoVacio : Exception
        {
            public override string Message => "Error por campo vacio";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ingreso_DatosAutos_Load(object sender, EventArgs e)
        {
            txtPatente.Select();
        }
    }
}
