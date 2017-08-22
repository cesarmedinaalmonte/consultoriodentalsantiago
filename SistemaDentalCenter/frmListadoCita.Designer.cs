namespace SistemaDentalCenter
{
    partial class frmListadoCita
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
            this.components = new System.ComponentModel.Container();
            this.gboxBusqueda_Cita = new System.Windows.Forms.GroupBox();
            this.dtgvCitas_BC = new System.Windows.Forms.DataGridView();
            this.classcitaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminar_BC = new System.Windows.Forms.Button();
            this.btnModificar_BC = new System.Windows.Forms.Button();
            this.btnCrear_BC = new System.Windows.Forms.Button();
            this.btnBuscar_BC = new System.Windows.Forms.Button();
            this.rdIDCita_BC = new System.Windows.Forms.RadioButton();
            this.rdCedula_BC = new System.Windows.Forms.RadioButton();
            this.rdIDPaciente_BC = new System.Windows.Forms.RadioButton();
            this.txtBuscar_BC = new System.Windows.Forms.TextBox();
            this.classcitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classcitaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classcitaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.classpatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classcitaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.classcitaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.classcitaBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.gboxBusqueda_Cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCitas_BC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxBusqueda_Cita
            // 
            this.gboxBusqueda_Cita.BackColor = System.Drawing.Color.Teal;
            this.gboxBusqueda_Cita.Controls.Add(this.dtgvCitas_BC);
            this.gboxBusqueda_Cita.Controls.Add(this.btnEliminar_BC);
            this.gboxBusqueda_Cita.Controls.Add(this.btnModificar_BC);
            this.gboxBusqueda_Cita.Controls.Add(this.btnCrear_BC);
            this.gboxBusqueda_Cita.Controls.Add(this.btnBuscar_BC);
            this.gboxBusqueda_Cita.Controls.Add(this.rdIDCita_BC);
            this.gboxBusqueda_Cita.Controls.Add(this.rdCedula_BC);
            this.gboxBusqueda_Cita.Controls.Add(this.rdIDPaciente_BC);
            this.gboxBusqueda_Cita.Controls.Add(this.txtBuscar_BC);
            this.gboxBusqueda_Cita.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxBusqueda_Cita.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gboxBusqueda_Cita.Location = new System.Drawing.Point(12, 21);
            this.gboxBusqueda_Cita.Name = "gboxBusqueda_Cita";
            this.gboxBusqueda_Cita.Size = new System.Drawing.Size(730, 453);
            this.gboxBusqueda_Cita.TabIndex = 18;
            this.gboxBusqueda_Cita.TabStop = false;
            this.gboxBusqueda_Cita.Text = "Buscador de Cita";
            // 
            // dtgvCitas_BC
            // 
            this.dtgvCitas_BC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCitas_BC.Location = new System.Drawing.Point(6, 122);
            this.dtgvCitas_BC.Name = "dtgvCitas_BC";
            this.dtgvCitas_BC.Size = new System.Drawing.Size(712, 314);
            this.dtgvCitas_BC.TabIndex = 15;
            this.dtgvCitas_BC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCitas_BC_CellContentClick_1);
            this.dtgvCitas_BC.DoubleClick += new System.EventHandler(this.dtgvCitas_BC_DoubleClick);
            // 
            // classcitaBindingSource5
            // 
            this.classcitaBindingSource5.DataSource = typeof(SistemaDentalCenter.Models.Class_cita);
            // 
            // btnEliminar_BC
            // 
            this.btnEliminar_BC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar_BC.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnEliminar_BC.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar_BC.Location = new System.Drawing.Point(606, 41);
            this.btnEliminar_BC.Name = "btnEliminar_BC";
            this.btnEliminar_BC.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar_BC.TabIndex = 14;
            this.btnEliminar_BC.Text = "Eliminar";
            this.btnEliminar_BC.UseVisualStyleBackColor = false;
            // 
            // btnModificar_BC
            // 
            this.btnModificar_BC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar_BC.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnModificar_BC.Location = new System.Drawing.Point(376, 41);
            this.btnModificar_BC.Name = "btnModificar_BC";
            this.btnModificar_BC.Size = new System.Drawing.Size(105, 35);
            this.btnModificar_BC.TabIndex = 13;
            this.btnModificar_BC.Text = "Modificar";
            this.btnModificar_BC.UseVisualStyleBackColor = false;
            // 
            // btnCrear_BC
            // 
            this.btnCrear_BC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrear_BC.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnCrear_BC.Location = new System.Drawing.Point(489, 41);
            this.btnCrear_BC.Name = "btnCrear_BC";
            this.btnCrear_BC.Size = new System.Drawing.Size(105, 35);
            this.btnCrear_BC.TabIndex = 12;
            this.btnCrear_BC.Text = "Nueva cita";
            this.btnCrear_BC.UseVisualStyleBackColor = false;
            // 
            // btnBuscar_BC
            // 
            this.btnBuscar_BC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar_BC.Font = new System.Drawing.Font("Cambria", 11F);
            this.btnBuscar_BC.Location = new System.Drawing.Point(261, 41);
            this.btnBuscar_BC.Name = "btnBuscar_BC";
            this.btnBuscar_BC.Size = new System.Drawing.Size(105, 35);
            this.btnBuscar_BC.TabIndex = 11;
            this.btnBuscar_BC.Text = "Buscar";
            this.btnBuscar_BC.UseVisualStyleBackColor = false;
            // 
            // rdIDCita_BC
            // 
            this.rdIDCita_BC.AutoSize = true;
            this.rdIDCita_BC.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIDCita_BC.Location = new System.Drawing.Point(98, 78);
            this.rdIDCita_BC.Name = "rdIDCita_BC";
            this.rdIDCita_BC.Size = new System.Drawing.Size(60, 19);
            this.rdIDCita_BC.TabIndex = 10;
            this.rdIDCita_BC.TabStop = true;
            this.rdIDCita_BC.Text = "Id Cita";
            this.rdIDCita_BC.UseVisualStyleBackColor = true;
            // 
            // rdCedula_BC
            // 
            this.rdCedula_BC.AutoSize = true;
            this.rdCedula_BC.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCedula_BC.Location = new System.Drawing.Point(174, 78);
            this.rdCedula_BC.Name = "rdCedula_BC";
            this.rdCedula_BC.Size = new System.Drawing.Size(62, 19);
            this.rdCedula_BC.TabIndex = 9;
            this.rdCedula_BC.TabStop = true;
            this.rdCedula_BC.Text = "Cédula";
            this.rdCedula_BC.UseVisualStyleBackColor = true;
            // 
            // rdIDPaciente_BC
            // 
            this.rdIDPaciente_BC.AutoSize = true;
            this.rdIDPaciente_BC.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIDPaciente_BC.Location = new System.Drawing.Point(7, 78);
            this.rdIDPaciente_BC.Name = "rdIDPaciente_BC";
            this.rdIDPaciente_BC.Size = new System.Drawing.Size(85, 19);
            this.rdIDPaciente_BC.TabIndex = 8;
            this.rdIDPaciente_BC.TabStop = true;
            this.rdIDPaciente_BC.Text = "Id Paciente";
            this.rdIDPaciente_BC.UseVisualStyleBackColor = true;
            // 
            // txtBuscar_BC
            // 
            this.txtBuscar_BC.Location = new System.Drawing.Point(6, 46);
            this.txtBuscar_BC.Name = "txtBuscar_BC";
            this.txtBuscar_BC.Size = new System.Drawing.Size(249, 26);
            this.txtBuscar_BC.TabIndex = 7;
            this.txtBuscar_BC.TextChanged += new System.EventHandler(this.txtBuscar_BC_TextChanged);
            // 
            // classcitaBindingSource
            // 
            this.classcitaBindingSource.DataSource = typeof(SistemaDentalCenter.Models.Class_cita);
            // 
            // classcitaBindingSource1
            // 
            this.classcitaBindingSource1.DataSource = typeof(SistemaDentalCenter.Models.Class_cita);
            // 
            // classcitaBindingSource2
            // 
            this.classcitaBindingSource2.DataSource = typeof(SistemaDentalCenter.Models.Class_cita);
            // 
            // classpatientBindingSource
            // 
            this.classpatientBindingSource.DataSource = typeof(SistemaDentalCenter.Models.Class_patient);
            // 
            // classcitaBindingSource3
            // 
            this.classcitaBindingSource3.DataSource = typeof(SistemaDentalCenter.Models.Class_cita);
            // 
            // classcitaBindingSource4
            // 
            this.classcitaBindingSource4.DataSource = typeof(SistemaDentalCenter.Models.Class_cita);
            // 
            // classcitaBindingSource6
            // 
            this.classcitaBindingSource6.DataSource = typeof(SistemaDentalCenter.Models.Class_cita);
            // 
            // frmListadoCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(755, 495);
            this.Controls.Add(this.gboxBusqueda_Cita);
            this.Name = "frmListadoCita";
            this.Text = "frmListadoCita";
            this.gboxBusqueda_Cita.ResumeLayout(false);
            this.gboxBusqueda_Cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCitas_BC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classcitaBindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxBusqueda_Cita;
        private System.Windows.Forms.Button btnEliminar_BC;
        private System.Windows.Forms.Button btnModificar_BC;
        private System.Windows.Forms.Button btnCrear_BC;
        private System.Windows.Forms.Button btnBuscar_BC;
        private System.Windows.Forms.RadioButton rdIDCita_BC;
        private System.Windows.Forms.RadioButton rdCedula_BC;
        private System.Windows.Forms.RadioButton rdIDPaciente_BC;
        private System.Windows.Forms.TextBox txtBuscar_BC;
        private System.Windows.Forms.BindingSource classcitaBindingSource;
        private System.Windows.Forms.BindingSource classcitaBindingSource1;
        private System.Windows.Forms.BindingSource classcitaBindingSource2;
        private System.Windows.Forms.DataGridView dtgvCitas_BC;
        private System.Windows.Forms.BindingSource classcitaBindingSource4;
        private System.Windows.Forms.BindingSource classpatientBindingSource;
        private System.Windows.Forms.BindingSource classcitaBindingSource3;
        private System.Windows.Forms.BindingSource classcitaBindingSource5;
        private System.Windows.Forms.BindingSource classcitaBindingSource6;
    }
}