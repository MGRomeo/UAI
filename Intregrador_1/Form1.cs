using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Intregrador_1
{
    public partial class Integrador_1 : Form
    {
        List<Persona> Lista_de_personas= new List<Persona>();
        List<Auto> Lista_de_autos = new List<Auto>();

        

        public Integrador_1()
        {
            InitializeComponent();
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        #region "Agregar"
        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Persona nuevapersona = new Persona(Interaction.InputBox("Dni: "), Interaction.InputBox("Nombre: "),Interaction.InputBox("Apellido: "));
            Lista_de_personas.Add(nuevapersona);
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = Lista_de_personas;

        }
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            Auto nuevoAuto = new Auto(Interaction.InputBox("Patente: "), Interaction.InputBox("Marca: "), Interaction.InputBox("Modelo: "), Interaction.InputBox("Año: "), decimal.Parse(Interaction.InputBox("Precio: ")));
            Lista_de_autos.Add(nuevoAuto);
            dgvAutos.DataSource = null;
            dgvAutos.DataSource = Lista_de_autos;
        }
        #endregion

        #region "Borrar"
        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            Lista_de_personas.Remove((Persona)dgvPersonas.SelectedRows[0].DataBoundItem);
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = Lista_de_personas;
            
        }
        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            Lista_de_autos.Remove((Auto)dgvAutos.SelectedRows[0].DataBoundItem);
            dgvAutos.DataSource = null;
            dgvAutos.DataSource = Lista_de_autos;
        }


        #endregion

        #region "Modificar"


        #endregion


        #region "Asignar"
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //Selecciono la persona desde su dgv y le aplico el metodo con el auto seleccionado de su dgv
            dgvAutosPorPersona.DataSource = null;
            dgvAutosPorPersona.DataSource = ((Persona)(dgvPersonas.SelectedRows[0].DataBoundItem)).AgregarAuto((Auto)(dgvAutos.SelectedRows[0].DataBoundItem));
        }
        #endregion





        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
