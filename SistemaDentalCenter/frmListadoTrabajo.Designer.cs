namespace SistemaDentalCenter
{
    partial class frmListadoTrabajo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxBusqueda_Paciente = new System.Windows.Forms.GroupBox();
            this.lblCierre_BP = new System.Windows.Forms.Label();
            this.dtgv_BP = new System.Windows.Forms.DataGridView();
            this.btnEliminar_BP = new System.Windows.Forms.Button();
            this.btnModificar_BP = new System.Windows.Forms.Button();
            this.btnCrearNuevo_BP = new System.Windows.Forms.Button();
            this.btnBuscar_BP = new System.Windows.Forms.Button();
            this.rdNombre_BP = new System.Windows.Forms.RadioButton();
            this.rdCedula_BP = new System.Windows.Forms.RadioButton();
            this.rdId_BP = new System.Windows.Forms.RadioButton();
            this.txtBusqueda_paciente = new System.Windows.Forms.TextBox();
            this.gboxBusqueda_Paciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BP)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxBusqueda_Paciente
            // 
            this.gboxBusqueda_Paciente.BackColor = System.Drawing.Color.Teal;
            this.gboxBusqueda_Paciente.Controls.Add(this.lblCierre_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.dtgv_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.btnEliminar_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.btnModificar_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.btnCrearNuevo_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.btnBuscar_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.rdNombre_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.rdCedula_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.rdId_BP);
            this.gboxBusqueda_Paciente.Controls.Add(this.txtBusqueda_paciente);
            this.gboxBusqueda_Paciente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxBusqueda_Paciente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gboxBusqueda_Paciente.Location = new System.Drawing.Point(12, 20);
            this.gboxBusqueda_Paciente.Name = "gboxBusqueda_Paciente";
            this.gboxBusqueda_Paciente.Size = new System.Drawing.Size(738, 436);
            this.gboxBusqueda_Paciente.TabIndex = 3;
            this.gboxBusqueda_Paciente.TabStop = false;
            this.gboxBusqueda_Paciente.Text = "frmbuscadorTrabajo";
            // 
            // lblCierre_BP
            // 
            this.lblCierre_BP.AutoSize = true;
            this.lblCierre_BP.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCierre_BP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCierre_BP.Location = new System.Drawing.Point(650, 11);
            this.lblCierre_BP.Name = "lblCierre_BP";
            this.lblCierre_BP.Size = new System.Drawing.Size(68, 18);
            this.lblCierre_BP.TabIndex = 16;
            this.lblCierre_BP.Text = "Regresar";
            this.lblCierre_BP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgv_BP
            // 
            this.dtgv_BP.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgv_BP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BP.Location = new System.Drawing.Point(7, 107);
            this.dtgv_BP.Name = "dtgv_BP";
            this.dtgv_BP.Size = new System.Drawing.Size(711, 323);
            this.dtgv_BP.TabIndex = 15;
            // 
            // btnEliminar_BP
            // 
            this.btnEliminar_BP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar_BP.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar_BP.Location = new System.Drawing.Point(604, 41);
            this.btnEliminar_BP.Name = "btnEliminar_BP";
            this.btnEliminar_BP.Size = new System.Drawing.Size(105, 35);
            this.btnEliminar_BP.TabIndex = 14;
            this.btnEliminar_BP.Text = "Eliminar";
            this.btnEliminar_BP.UseVisualStyleBackColor = false;
            // 
            // btnModificar_BP
            // 
            this.btnModificar_BP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar_BP.Location = new System.Drawing.Point(359, 41);
            this.btnModificar_BP.Name = "btnModificar_BP";
            this.btnModificar_BP.Size = new System.Drawing.Size(94, 35);
            this.btnModificar_BP.TabIndex = 13;
            this.btnModificar_BP.Text = "Modificar";
            this.btnModificar_BP.UseVisualStyleBackColor = false;
            // 
            // btnCrearNuevo_BP
            // 
            this.btnCrearNuevo_BP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearNuevo_BP.Location = new System.Drawing.Point(459, 41);
            this.btnCrearNuevo_BP.Name = "btnCrearNuevo_BP";
            this.btnCrearNuevo_BP.Size = new System.Drawing.Size(127, 35);
            this.btnCrearNuevo_BP.TabIndex = 12;
            this.btnCrearNuevo_BP.Text = "Nuevo trabajo";
            this.btnCrearNuevo_BP.UseVisualStyleBackColor = false;
            // 
            // btnBuscar_BP
            // 
            this.btnBuscar_BP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar_BP.Location = new System.Drawing.Point(261, 41);
            this.btnBuscar_BP.Name = "btnBuscar_BP";
            this.btnBuscar_BP.Size = new System.Drawing.Size(92, 35);
            this.btnBuscar_BP.TabIndex = 11;
            this.btnBuscar_BP.Text = "Buscar";
            this.btnBuscar_BP.UseVisualStyleBackColor = false;
            // 
            // rdNombre_BP
            // 
            this.rdNombre_BP.AutoSize = true;
            this.rdNombre_BP.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNombre_BP.Location = new System.Drawing.Point(143, 78);
            this.rdNombre_BP.Name = "rdNombre_BP";
            this.rdNombre_BP.Size = new System.Drawing.Size(70, 19);
            this.rdNombre_BP.TabIndex = 10;
            this.rdNombre_BP.TabStop = true;
            this.rdNombre_BP.Text = "Nombre";
            this.rdNombre_BP.UseVisualStyleBackColor = true;
            // 
            // rdCedula_BP
            // 
            this.rdCedula_BP.AutoSize = true;
            this.rdCedula_BP.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCedula_BP.Location = new System.Drawing.Point(66, 78);
            this.rdCedula_BP.Name = "rdCedula_BP";
            this.rdCedula_BP.Size = new System.Drawing.Size(62, 19);
            this.rdCedula_BP.TabIndex = 9;
            this.rdCedula_BP.TabStop = true;
            this.rdCedula_BP.Text = "Cédula";
            this.rdCedula_BP.UseVisualStyleBackColor = true;
            // 
            // rdId_BP
            // 
            this.rdId_BP.AutoSize = true;
            this.rdId_BP.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdId_BP.Location = new System.Drawing.Point(7, 78);
            this.rdId_BP.Name = "rdId_BP";
            this.rdId_BP.Size = new System.Drawing.Size(36, 19);
            this.rdId_BP.TabIndex = 8;
            this.rdId_BP.TabStop = true;
            this.rdId_BP.Text = "Id";
            this.rdId_BP.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda_paciente
            // 
            this.txtBusqueda_paciente.Location = new System.Drawing.Point(6, 46);
            this.txtBusqueda_paciente.Name = "txtBusqueda_paciente";
            this.txtBusqueda_paciente.Size = new System.Drawing.Size(249, 26);
            this.txtBusqueda_paciente.TabIndex = 7;
            // 
            // frmListadoTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(773, 488);
            this.Controls.Add(this.gboxBusqueda_Paciente);
            this.Name = "frmListadoTrabajo";
            this.Text = "frmListadoTrabajo";
            this.gboxBusqueda_Paciente.ResumeLayout(false);
            this.gboxBusqueda_Paciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxBusqueda_Paciente;
        private System.Windows.Forms.Label lblCierre_BP;
        private System.Windows.Forms.DataGridView dtgv_BP;
        private System.Windows.Forms.Button btnEliminar_BP;
        private System.Windows.Forms.Button btnModificar_BP;
        private System.Windows.Forms.Button btnCrearNuevo_BP;
        private System.Windows.Forms.Button btnBuscar_BP;
        private System.Windows.Forms.RadioButton rdNombre_BP;
        private System.Windows.Forms.RadioButton rdCedula_BP;
        private System.Windows.Forms.RadioButton rdId_BP;
        private System.Windows.Forms.TextBox txtBusqueda_paciente;
    }
}