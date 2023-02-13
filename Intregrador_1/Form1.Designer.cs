namespace Intregrador_1
{
    partial class Integrador_1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.dgvAutosPorPersona = new System.Windows.Forms.DataGridView();
            this.dgvDatosAutos = new System.Windows.Forms.DataGridView();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnModificarPersona = new System.Windows.Forms.Button();
            this.btnBorrarPersona = new System.Windows.Forms.Button();
            this.btnBorrarAuto = new System.Windows.Forms.Button();
            this.btnModificarAuto = new System.Windows.Forms.Button();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.btnEliminarAutoDeLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosPorPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(34, 52);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(291, 150);
            this.dgvPersonas.TabIndex = 0;
            // 
            // dgvAutos
            // 
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Location = new System.Drawing.Point(505, 52);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.Size = new System.Drawing.Size(291, 150);
            this.dgvAutos.TabIndex = 1;
            // 
            // dgvAutosPorPersona
            // 
            this.dgvAutosPorPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosPorPersona.Location = new System.Drawing.Point(34, 275);
            this.dgvAutosPorPersona.Name = "dgvAutosPorPersona";
            this.dgvAutosPorPersona.Size = new System.Drawing.Size(291, 150);
            this.dgvAutosPorPersona.TabIndex = 2;
            // 
            // dgvDatosAutos
            // 
            this.dgvDatosAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAutos.Location = new System.Drawing.Point(505, 275);
            this.dgvDatosAutos.Name = "dgvDatosAutos";
            this.dgvDatosAutos.Size = new System.Drawing.Size(291, 150);
            this.dgvDatosAutos.TabIndex = 3;
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(59, 214);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarPersona.TabIndex = 4;
            this.btnAgregarPersona.Text = "Agregar persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Location = new System.Drawing.Point(221, 214);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(75, 38);
            this.btnModificarPersona.TabIndex = 6;
            this.btnModificarPersona.Text = "Modificar Persona";
            this.btnModificarPersona.UseVisualStyleBackColor = true;
            // 
            // btnBorrarPersona
            // 
            this.btnBorrarPersona.Location = new System.Drawing.Point(140, 214);
            this.btnBorrarPersona.Name = "btnBorrarPersona";
            this.btnBorrarPersona.Size = new System.Drawing.Size(75, 38);
            this.btnBorrarPersona.TabIndex = 8;
            this.btnBorrarPersona.Text = "Borrar Persona";
            this.btnBorrarPersona.UseVisualStyleBackColor = true;
            this.btnBorrarPersona.Click += new System.EventHandler(this.btnBorrarPersona_Click);
            // 
            // btnBorrarAuto
            // 
            this.btnBorrarAuto.Location = new System.Drawing.Point(613, 214);
            this.btnBorrarAuto.Name = "btnBorrarAuto";
            this.btnBorrarAuto.Size = new System.Drawing.Size(75, 38);
            this.btnBorrarAuto.TabIndex = 11;
            this.btnBorrarAuto.Text = "Borrar auto";
            this.btnBorrarAuto.UseVisualStyleBackColor = true;
            this.btnBorrarAuto.Click += new System.EventHandler(this.btnBorrarAuto_Click);
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(694, 214);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(75, 38);
            this.btnModificarAuto.TabIndex = 10;
            this.btnModificarAuto.Text = "Modificar Auto";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(532, 214);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarAuto.TabIndex = 9;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(373, 108);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(79, 41);
            this.btnAsignar.TabIndex = 12;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(873, 427);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 42);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(387, 349);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(75, 60);
            this.btnGC.TabIndex = 14;
            this.btnGC.Text = "Ejecutar Garabge Collector";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // btnEliminarAutoDeLista
            // 
            this.btnEliminarAutoDeLista.Location = new System.Drawing.Point(256, 432);
            this.btnEliminarAutoDeLista.Name = "btnEliminarAutoDeLista";
            this.btnEliminarAutoDeLista.Size = new System.Drawing.Size(75, 61);
            this.btnEliminarAutoDeLista.TabIndex = 15;
            this.btnEliminarAutoDeLista.Text = "Eliminar auto de la lista";
            this.btnEliminarAutoDeLista.UseVisualStyleBackColor = true;
            // 
            // Integrador_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 521);
            this.Controls.Add(this.btnEliminarAutoDeLista);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnBorrarAuto);
            this.Controls.Add(this.btnModificarAuto);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.btnBorrarPersona);
            this.Controls.Add(this.btnModificarPersona);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.dgvDatosAutos);
            this.Controls.Add(this.dgvAutosPorPersona);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "Integrador_1";
            this.Text = "Integrador_1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosPorPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.DataGridView dgvAutosPorPersona;
        private System.Windows.Forms.DataGridView dgvDatosAutos;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnModificarPersona;
        private System.Windows.Forms.Button btnBorrarPersona;
        private System.Windows.Forms.Button btnBorrarAuto;
        private System.Windows.Forms.Button btnModificarAuto;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnEliminarAutoDeLista;
    }
}

