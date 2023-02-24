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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLiberarAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosPorPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(12, 38);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(344, 150);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.SelectionChanged += new System.EventHandler(this.dgvPersonas_SelectionChanged);
            // 
            // dgvAutos
            // 
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Location = new System.Drawing.Point(569, 38);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.Size = new System.Drawing.Size(344, 150);
            this.dgvAutos.TabIndex = 1;
            this.dgvAutos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutos_RowEnter);
            // 
            // dgvAutosPorPersona
            // 
            this.dgvAutosPorPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosPorPersona.Location = new System.Drawing.Point(12, 292);
            this.dgvAutosPorPersona.Name = "dgvAutosPorPersona";
            this.dgvAutosPorPersona.Size = new System.Drawing.Size(344, 150);
            this.dgvAutosPorPersona.TabIndex = 2;
            // 
            // dgvDatosAutos
            // 
            this.dgvDatosAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAutos.Location = new System.Drawing.Point(406, 292);
            this.dgvDatosAutos.Name = "dgvDatosAutos";
            this.dgvDatosAutos.Size = new System.Drawing.Size(661, 100);
            this.dgvDatosAutos.TabIndex = 3;
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(26, 194);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarPersona.TabIndex = 4;
            this.btnAgregarPersona.Text = "Agregar persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Location = new System.Drawing.Point(263, 194);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(75, 38);
            this.btnModificarPersona.TabIndex = 6;
            this.btnModificarPersona.Text = "Modificar Persona";
            this.btnModificarPersona.UseVisualStyleBackColor = true;
            this.btnModificarPersona.Click += new System.EventHandler(this.btnModificarPersona_Click);
            // 
            // btnBorrarPersona
            // 
            this.btnBorrarPersona.Location = new System.Drawing.Point(139, 194);
            this.btnBorrarPersona.Name = "btnBorrarPersona";
            this.btnBorrarPersona.Size = new System.Drawing.Size(75, 38);
            this.btnBorrarPersona.TabIndex = 8;
            this.btnBorrarPersona.Text = "Borrar Persona";
            this.btnBorrarPersona.UseVisualStyleBackColor = true;
            this.btnBorrarPersona.Click += new System.EventHandler(this.btnBorrarPersona_Click);
            // 
            // btnBorrarAuto
            // 
            this.btnBorrarAuto.Location = new System.Drawing.Point(702, 194);
            this.btnBorrarAuto.Name = "btnBorrarAuto";
            this.btnBorrarAuto.Size = new System.Drawing.Size(75, 38);
            this.btnBorrarAuto.TabIndex = 11;
            this.btnBorrarAuto.Text = "Borrar auto";
            this.btnBorrarAuto.UseVisualStyleBackColor = true;
            this.btnBorrarAuto.Click += new System.EventHandler(this.btnBorrarAuto_Click);
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(819, 194);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(75, 38);
            this.btnModificarAuto.TabIndex = 10;
            this.btnModificarAuto.Text = "Modificar Auto";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
            this.btnModificarAuto.Click += new System.EventHandler(this.btnModificarAuto_Click);
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(583, 194);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(75, 38);
            this.btnAgregarAuto.TabIndex = 9;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(419, 79);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(90, 58);
            this.btnAsignar.TabIndex = 12;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(995, 467);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 42);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(977, 79);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(90, 67);
            this.btnGC.TabIndex = 14;
            this.btnGC.Text = "Ejecutar Garabge Collector";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Autos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Autos por Persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Detalle Auto";
            // 
            // btnLiberarAuto
            // 
            this.btnLiberarAuto.Location = new System.Drawing.Point(277, 454);
            this.btnLiberarAuto.Name = "btnLiberarAuto";
            this.btnLiberarAuto.Size = new System.Drawing.Size(79, 43);
            this.btnLiberarAuto.TabIndex = 20;
            this.btnLiberarAuto.Text = "Liberar Auto";
            this.btnLiberarAuto.UseVisualStyleBackColor = true;
            this.btnLiberarAuto.Click += new System.EventHandler(this.btnLiberarAuto_Click);
            // 
            // Integrador_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 521);
            this.Controls.Add(this.btnLiberarAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.Integrador_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosPorPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLiberarAuto;
    }
}

