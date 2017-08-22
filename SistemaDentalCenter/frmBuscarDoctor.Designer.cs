namespace SistemaDentalCenter
{
    partial class frmBuscarDoctor
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
            this.gboxBusqueda_Cita = new System.Windows.Forms.GroupBox();
            this.dtgvBuscarDoctor__BD = new System.Windows.Forms.DataGridView();
            this.btnEliminar_BD = new System.Windows.Forms.Button();
            this.btnModificar_BD = new System.Windows.Forms.Button();
            this.btnCrear_BD = new System.Windows.Forms.Button();
            this.btnBuscar_BD = new System.Windows.Forms.Button();
            this.rdExecuatur_BD = new System.Windows.Forms.RadioButton();
            this.rdCedula_BD = new System.Windows.Forms.RadioButton();
            this.rdId_BD = new System.Windows.Forms.RadioButton();
            this.txtBuscar_BD = new System.Windows.Forms.TextBox();
            this.gboxBusqueda_Cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBuscarDoctor__BD)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxBusqueda_Cita
            // 
            this.gboxBusqueda_Cita.BackColor = System.Drawing.Color.Teal;
            this.gboxBusqueda_Cita.Controls.Add(this.dtgvBuscarDoctor__BD);
            this.gboxBusqueda_Cita.Controls.Add(this.btnEliminar_BD);
            this.gboxBusqueda_Cita.Controls.Add(this.btnModificar_BD);
            this.gboxBusqueda_Cita.Controls.Add(this.btnCrear_BD);
            this.gboxBusqueda_Cita.Controls.Add(this.btnBuscar_BD);
            this.gboxBusqueda_Cita.Controls.Add(this.rdExecuatur_BD);
            this.gboxBusqueda_Cita.Controls.Add(this.rdCedula_BD);
            this.gboxBusqueda_Cita.Controls.Add(this.rdId_BD);
            this.gboxBusqueda_Cita.Controls.Add(this.txtBuscar_BD);
            this.gboxBusqueda_Cita.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxBusqueda_Cita.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gboxBusqueda_Cita.Location = new System.Drawing.Point(12, 12);
            this.gboxBusqueda_Cita.Name = "gboxBusqueda_Cita";
            this.gboxBusqueda_Cita.Size = new System.Drawing.Size(730, 453);
            this.gboxBusqueda_Cita.TabIndex = 18;
            this.gboxBusqueda_Cita.TabStop = false;
            this.gboxBusqueda_Cita.Text = "Buscador de Cita";
            // 
            // dtgvBuscarDoctor__BD
            // 
            this.dtgvBuscarDoctor__BD.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgvBuscarDoctor__BD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBuscarDoctor__BD.Location = new System.Drawing.Point(7, 107);
            this.dtgvBuscarDoctor__BD.Name = "dtgvBuscarDoctor__BD";
            this.dtgvBuscarDoctor__BD.Size = new System.Drawing.Size(711, 323);
            this.dtgvBuscarDoctor__BD.TabIndex = 15;
            // 
            // btnEliminar_BD
            // 
            this.btnEliminar_BD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar_BD.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_BD.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar_BD.Location = new System.Drawing.Point(606, 41);
            this.btnEliminar_BD.Name = "btnEliminar_BD";
            this.btnEliminar_BD.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar_BD.TabIndex = 14;
            this.btnEliminar_BD.Text = "Eliminar";
            this.btnEliminar_BD.UseVisualStyleBackColor = false;
            // 
            // btnModificar_BD
            // 
            this.btnModificar_BD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar_BD.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar_BD.Location = new System.Drawing.Point(372, 41);
            this.btnModificar_BD.Name = "btnModificar_BD";
            this.btnModificar_BD.Size = new System.Drawing.Size(105, 35);
            this.btnModificar_BD.TabIndex = 13;
            this.btnModificar_BD.Text = "Modificar";
            this.btnModificar_BD.UseVisualStyleBackColor = false;
            // 
            // btnCrear_BD
            // 
            this.btnCrear_BD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrear_BD.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear_BD.Location = new System.Drawing.Point(483, 41);
            this.btnCrear_BD.Name = "btnCrear_BD";
            this.btnCrear_BD.Size = new System.Drawing.Size(110, 35);
            this.btnCrear_BD.TabIndex = 12;
            this.btnCrear_BD.Text = "Nuevo doctor";
            this.btnCrear_BD.UseVisualStyleBackColor = false;
            // 
            // btnBuscar_BD
            // 
            this.btnBuscar_BD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar_BD.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar_BD.Location = new System.Drawing.Point(261, 41);
            this.btnBuscar_BD.Name = "btnBuscar_BD";
            this.btnBuscar_BD.Size = new System.Drawing.Size(105, 35);
            this.btnBuscar_BD.TabIndex = 11;
            this.btnBuscar_BD.Text = "Buscar";
            this.btnBuscar_BD.UseVisualStyleBackColor = false;
            // 
            // rdExecuatur_BD
            // 
            this.rdExecuatur_BD.AutoSize = true;
            this.rdExecuatur_BD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdExecuatur_BD.Location = new System.Drawing.Point(67, 78);
            this.rdExecuatur_BD.Name = "rdExecuatur_BD";
            this.rdExecuatur_BD.Size = new System.Drawing.Size(80, 19);
            this.rdExecuatur_BD.TabIndex = 10;
            this.rdExecuatur_BD.TabStop = true;
            this.rdExecuatur_BD.Text = "Exequátur";
            this.rdExecuatur_BD.UseVisualStyleBackColor = true;
            // 
            // rdCedula_BD
            // 
            this.rdCedula_BD.AutoSize = true;
            this.rdCedula_BD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCedula_BD.Location = new System.Drawing.Point(153, 78);
            this.rdCedula_BD.Name = "rdCedula_BD";
            this.rdCedula_BD.Size = new System.Drawing.Size(62, 19);
            this.rdCedula_BD.TabIndex = 9;
            this.rdCedula_BD.TabStop = true;
            this.rdCedula_BD.Text = "Cédula";
            this.rdCedula_BD.UseVisualStyleBackColor = true;
            // 
            // rdId_BD
            // 
            this.rdId_BD.AutoSize = true;
            this.rdId_BD.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdId_BD.Location = new System.Drawing.Point(7, 78);
            this.rdId_BD.Name = "rdId_BD";
            this.rdId_BD.Size = new System.Drawing.Size(39, 19);
            this.rdId_BD.TabIndex = 8;
            this.rdId_BD.TabStop = true;
            this.rdId_BD.Text = "Id ";
            this.rdId_BD.UseVisualStyleBackColor = true;
            // 
            // txtBuscar_BD
            // 
            this.txtBuscar_BD.Location = new System.Drawing.Point(6, 46);
            this.txtBuscar_BD.Name = "txtBuscar_BD";
            this.txtBuscar_BD.Size = new System.Drawing.Size(249, 26);
            this.txtBuscar_BD.TabIndex = 7;
            this.txtBuscar_BD.TextChanged += new System.EventHandler(this.txtBuscar_BD_TextChanged);
            // 
            // frmBuscarDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(755, 487);
            this.Controls.Add(this.gboxBusqueda_Cita);
            this.Name = "frmBuscarDoctor";
            this.Text = "frmBuscarDoctor";
            this.gboxBusqueda_Cita.ResumeLayout(false);
            this.gboxBusqueda_Cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBuscarDoctor__BD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxBusqueda_Cita;
        private System.Windows.Forms.DataGridView dtgvBuscarDoctor__BD;
        private System.Windows.Forms.Button btnEliminar_BD;
        private System.Windows.Forms.Button btnModificar_BD;
        private System.Windows.Forms.Button btnCrear_BD;
        private System.Windows.Forms.Button btnBuscar_BD;
        private System.Windows.Forms.RadioButton rdExecuatur_BD;
        private System.Windows.Forms.RadioButton rdCedula_BD;
        private System.Windows.Forms.RadioButton rdId_BD;
        private System.Windows.Forms.TextBox txtBuscar_BD;
    }
}