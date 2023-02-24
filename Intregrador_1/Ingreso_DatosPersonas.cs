using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intregrador_1
{
    public partial class Ingreso_DatosPersonas : Form
    {
        public Persona persona;// puede ser una property get

        public Ingreso_DatosPersonas()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDni.Text == "" || txtNombre.Text == "" || txtApellido.Text == "")
                {
                    throw new IngresoVacio();
                }
                else
                {
                    string Dni = txtDni.Text;
                    string Nombre = txtNombre.Text;
                    string Apellido = txtApellido.Text;
                    Persona persona = new Persona(Dni, Nombre, Apellido);
                    Program.integrador.CargaDgvPersona(persona);
                    Close();
                }
            }
            catch (IngresoVacio) when (txtDni.Text == "") { MessageBox.Show("Debe ingresar un DNI", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            catch (IngresoVacio) when (txtNombre.Text == "") { MessageBox.Show("Debe ingresar un Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            catch (IngresoVacio) when (txtApellido.Text == "") { MessageBox.Show("Debe ingresar un Apellido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        public class IngresoVacio : Exception
        {
            public override string Message => "Error por campo vacio";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Ingreso_DatosPersonas_Load(object sender, EventArgs e)
        {
            txtDni.Select();
        }
    }
}
