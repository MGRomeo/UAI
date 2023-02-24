using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Intregrador_1
{
    public partial class Integrador_1 : Form
    {
        List<Persona> Lista_de_personas = new List<Persona>();
        List<Auto> Lista_de_autos = new List<Auto>();

        public Integrador_1()
        {
            InitializeComponent();
        }

        #region Agregar

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Ingreso_DatosPersonas frmIngreso = new Ingreso_DatosPersonas();
            frmIngreso.Show();
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            Ingreso_DatosAutos frmAutos = new Ingreso_DatosAutos();
            frmAutos.Show();
        }

        #endregion

        #region Borrar / G.C. 

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                Persona persona = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;
                LiberarAutosPorBorradoDePersona(persona);
                Lista_de_personas.Remove(persona);
                persona = null;
                dgvPersonas.DataSource = null;
                dgvAutosPorPersona.DataSource = null;
                dgvPersonas.DataSource = Lista_de_personas;
            }

        }

        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            if (dgvAutos.SelectedRows.Count > 0)
            {
                Lista_de_autos.Remove((Auto)dgvAutos.SelectedRows[0].DataBoundItem);
                dgvAutos.DataSource = null;
                dgvDatosAutos.DataSource = null;
                ListaAutoVacia();
                dgvAutos.DataSource = Lista_de_autos;
            }
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        #endregion

        #region Modificar

        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = ((Persona)(dgvPersonas.SelectedRows[0].DataBoundItem));
                Ingreso_DatosPersonas frmIngreso = new Ingreso_DatosPersonas();
                frmIngreso.Show();
                frmIngreso.lblTitulo.Text = "Modificar";
                frmIngreso.txtDni.Text = p.DNI;
                frmIngreso.txtNombre.Text = p.Nombre;
                frmIngreso.txtApellido.Text = p.Apellido;
                Buscar_y_EliminarPersona(p);
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Debe seleccionar una Persona", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
 
        }
        private void btnModificarAuto_Click(object sender, EventArgs e)
        {

            try
            {
                Auto a = (Auto)(dgvAutos.SelectedRows[0].DataBoundItem);
                Ingreso_DatosAutos frmAutos = new Ingreso_DatosAutos();
                frmAutos.Show();
                frmAutos.lblTitulo.Text = "Modificar";
                frmAutos.txtPatente.Text = a.Patente;
                frmAutos.txtMarca.Text = a.Marca;
                frmAutos.txtModelo.Text = a.Modelo;
                frmAutos.txtAño.Text = a.Año;
                frmAutos.txtPrecio.Text = (a.Precio.ToString());
                Buscar_y_EliminarAuto(a);
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Debe seleccionar una Persona", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        #endregion

        #region Asignar / Liberar

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                Auto aux = (Auto)(dgvAutos.SelectedRows[0].DataBoundItem);
                if (aux.Dueño() == false)
                {
                    //Selecciono la persona desde su dgv y le aplico el metodo con el auto seleccionado de su dgv
                    Persona persona = ((Persona)(dgvPersonas.SelectedRows[0].DataBoundItem));
                    dgvAutosPorPersona.DataSource = null;
                    aux.AsignarDueño(persona);
                    dgvAutosPorPersona.DataSource = persona.AgregarAuto((Auto)(dgvAutos.SelectedRows[0].DataBoundItem));
                    ActualizarDgvDatosAutos(aux);
                    dgvAutosPorPersona.Columns["TieneDuenio"].Visible = false;
                    dgvAutosPorPersona.Columns["año"].Visible = false;
                    dgvAutosPorPersona.Columns["Precio"].Visible = false;
                    dgvAutosPorPersona.Columns["Persona"].Visible = false;
                }
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Debe seleccionar un Auto y una Persona", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void btnLiberarAuto_Click(object sender, EventArgs e)
        {
            if (dgvAutos.SelectedRows.Count > 0)
            {
                Auto aux = (Auto)(dgvAutos.SelectedRows[0].DataBoundItem);

                foreach (var p in Lista_de_personas)
                {
                    foreach (var a in p.Lista_de_Autos_por_persona)
                    {
                        if (a.Patente == aux.Patente)
                        {
                            if (a.TieneDuenio == true)
                            {
                                a.TieneDuenio = false;
                                a.Persona = null;
                                ActualizarDgvDatosAutos(aux);
                                MessageBox.Show($"El auto fue desvinculado de la persona: {p.Apellido},{p.Nombre}", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    p.Lista_de_Autos_por_persona.Remove(aux);
                    if (dgvPersonas.SelectedRows.Count > 0)
                    {
                        Persona persona = ((Persona)(dgvPersonas.SelectedRows[0].DataBoundItem));
                        dgvAutosPorPersona.DataSource = null;
                        dgvAutosPorPersona.DataSource = persona.Lista_de_Autos_por_persona;
                    }
                }
            }
        }
        public void LiberarAutosPorBorradoDePersona(Persona p)
        {
            try
            {
                foreach (var a in p.Lista_de_Autos_por_persona)//Busco los autos en la lista de autos de la persona, cambio el estado de tiene dueño y quito el puntero a la persona
                {
                    if (p.Lista_de_Autos_por_persona.Count ==1)
                    {
                        a.TieneDuenio = false;
                        a.Persona = null; // Borro el puntero a persona, para ejecutar el GC
                        ActualizarDgvDatosAutos(a);
                        p.Lista_de_Autos_por_persona.Remove(a);
                        dgvAutosPorPersona.DataSource = null;
                        dgvAutosPorPersona.DataSource = p.Lista_de_Autos_por_persona;
                        MessageBox.Show("Autos de la persona Liberados","Atención",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        a.TieneDuenio = false;
                        a.Persona = null; // Borro el puntero a persona, para ejecutar el GC
                        ActualizarDgvDatosAutos(a);
                        p.Lista_de_Autos_por_persona.Remove(a);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo falló", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Métodos Miscelaneos

        //cuando cambio la seleccion de personas en Dgv
        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                Persona persona = ((Persona)(dgvPersonas.SelectedRows[0].DataBoundItem));
                dgvAutosPorPersona.DataSource = null;
                dgvAutosPorPersona.DataSource = persona.Lista_de_Autos_por_persona;
                dgvAutosPorPersona.Columns["TieneDuenio"].Visible = false;
                dgvAutosPorPersona.Columns["año"].Visible = false;
                dgvAutosPorPersona.Columns["Precio"].Visible = false;
                dgvAutosPorPersona.Columns["Persona"].Visible = false;
            }
        }

        public void ActualizarDgvDatosAutos(Auto a)
        {
            dgvDatosAutos.DataSource = null;
            dgvDatosAutos.ColumnCount = 6;
            dgvDatosAutos.Columns[0].Name = "Marca";
            dgvDatosAutos.Rows[0].Cells[0].Value = a.Marca;
            dgvDatosAutos.Columns[1].Name = "Año";
            dgvDatosAutos.Rows[0].Cells[1].Value = a.Año;
            dgvDatosAutos.Columns[2].Name = "Modelo";
            dgvDatosAutos.Rows[0].Cells[2].Value = a.Modelo;
            dgvDatosAutos.Columns[3].Name = "Patente";
            dgvDatosAutos.Rows[0].Cells[3].Value = a.Patente;
            if (a.Persona != null)
            {
                dgvDatosAutos.Columns[4].Name = "Dni";
                dgvDatosAutos.Rows[0].Cells[4].Value = a.Persona.DNI;
                dgvDatosAutos.Columns[5].Name = "Apellido y Nombre";
                dgvDatosAutos.Rows[0].Cells[5].Value = a.Persona.Nombre + " , " + a.Persona.Apellido;
            }
            else
            {
                dgvDatosAutos.Columns[4].Name = "Dni";
                dgvDatosAutos.Columns[5].Name = "Apellido y Nombre";
                dgvDatosAutos.Rows[0].Cells[4].Value = " - ";
                dgvDatosAutos.Rows[0].Cells[5].Value = " -  ,  - ";
            }
        }

        public void ListaAutoVacia()
        {
            if (Lista_de_autos.Count == 0)
            {
                dgvDatosAutos.ColumnCount = 6;
                dgvDatosAutos.Columns[0].Name = "Marca";
                dgvDatosAutos.Rows[0].Cells[0].Value = " - ";
                dgvDatosAutos.Columns[1].Name = "Año";
                dgvDatosAutos.Rows[0].Cells[1].Value = "-";
                dgvDatosAutos.Columns[2].Name = "Modelo";
                dgvDatosAutos.Rows[0].Cells[2].Value = "-";
                dgvDatosAutos.Columns[3].Name = "Patente";
                dgvDatosAutos.Rows[0].Cells[3].Value = "-";
                dgvDatosAutos.Columns[4].Name = "Dni";
                dgvDatosAutos.Rows[0].Cells[4].Value = " - ";
                dgvDatosAutos.Columns[5].Name = "Apellido y Nombre";
                dgvDatosAutos.Rows[0].Cells[5].Value = " -  ,  - ";
            }
        }

        private void dgvAutos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAutos.SelectedRows.Count > 0)
            {
                dgvDatosAutos.DataSource = null;
                Auto auto = ((Auto)(dgvAutos.SelectedRows[0].DataBoundItem));
                ActualizarDgvDatosAutos(auto);
            }
        }

        private void Integrador_1_Load(object sender, EventArgs e)
        {
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosAutos.ReadOnly = true;
            dgvAutosPorPersona.ReadOnly = true;
        }

        public void CargaDgvPersona(Persona p)
        {
            Lista_de_personas.Add(p);
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = Lista_de_personas;

        }

        public void CargaDgvAutos(Auto a)
        {
            Lista_de_autos.Add(a);
            dgvAutos.DataSource = null;
            dgvAutos.DataSource = Lista_de_autos;
            dgvAutos.Columns["TieneDuenio"].Visible = false;
            dgvAutos.Columns["año"].Visible = false;
            dgvAutos.Columns["Precio"].Visible = false;
            dgvAutos.Columns["Persona"].Visible = false;
        }

        public void Buscar_y_EliminarPersona(Persona p)
        {
            foreach (var aux in Lista_de_personas)
            {
                if (aux.DNI == p.DNI)
                {
                    Lista_de_personas.Remove(aux);
                    return;
                }
            }
        }

        public void Buscar_y_EliminarAuto(Auto a)
        {
            foreach (var aux in Lista_de_autos)
            {
                if (aux.Patente == a.Patente)
                {
                    Lista_de_autos.Remove(aux);
                    return;
                }
            }
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
