namespace SistemaDentalCenter
{
    partial class frmBuscarPaciente
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
            this.button1 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classpatientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.classpatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classpatientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gboxBusqueda_Paciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource1)).BeginInit();
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
            this.gboxBusqueda_Paciente.Location = new System.Drawing.Point(13, 23);
            this.gboxBusqueda_Paciente.Name = "gboxBusqueda_Paciente";
            this.gboxBusqueda_Paciente.Size = new System.Drawing.Size(738, 436);
            this.gboxBusqueda_Paciente.TabIndex = 2;
            this.gboxBusqueda_Paciente.TabStop = false;
            this.gboxBusqueda_Paciente.Text = "Buscador de Paciente";
            this.gboxBusqueda_Paciente.Enter += new System.EventHandler(this.gboxBusqueda_Paciente_Enter);
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
            this.dtgv_BP.AutoGenerateColumns = false;
            this.dtgv_BP.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgv_BP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.arsDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dtgv_BP.DataSource = this.classpatientBindingSource2;
            this.dtgv_BP.Location = new System.Drawing.Point(7, 107);
            this.dtgv_BP.Name = "dtgv_BP";
            this.dtgv_BP.Size = new System.Drawing.Size(711, 323);
            this.dtgv_BP.TabIndex = 15;
            this.dtgv_BP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_BP_CellClick);
            this.dtgv_BP.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_BP_CellMouseDoubleClick);
            this.dtgv_BP.DoubleClick += new System.EventHandler(this.dtgv_BP_DoubleClick);
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
            this.btnCrearNuevo_BP.Text = "Nuevo paciente";
            this.btnCrearNuevo_BP.UseVisualStyleBackColor = false;
            this.btnCrearNuevo_BP.Click += new System.EventHandler(this.btnCrearNuevo_BP_Click);
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
            this.btnBuscar_BP.Click += new System.EventHandler(this.btnBuscar_BP_Click);
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
            this.rdCedula_BP.CheckedChanged += new System.EventHandler(this.rdCedula_BP_CheckedChanged);
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
            this.rdId_BP.CheckedChanged += new System.EventHandler(this.rdId_BP_CheckedChanged);
            // 
            // txtBusqueda_paciente
            // 
            this.txtBusqueda_paciente.Location = new System.Drawing.Point(6, 46);
            this.txtBusqueda_paciente.Name = "txtBusqueda_paciente";
            this.txtBusqueda_paciente.Size = new System.Drawing.Size(249, 26);
            this.txtBusqueda_paciente.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(639, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // arsDataGridViewTextBoxColumn
            // 
            this.arsDataGridViewTextBoxColumn.DataPropertyName = "ars";
            this.arsDataGridViewTextBoxColumn.HeaderText = "ars";
            this.arsDataGridViewTextBoxColumn.Name = "arsDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // classpatientBindingSource2
            // 
            this.classpatientBindingSource2.DataSource = typeof(SistemaDentalCenter.Models.Class_patient);
            // 
            // classpatientBindingSource
            // 
            this.classpatientBindingSource.DataSource = typeof(SistemaDentalCenter.Models.Class_patient);
            // 
            // classpatientBindingSource1
            // 
            this.classpatientBindingSource1.DataSource = typeof(SistemaDentalCenter.Models.Class_patient);
            // 
            // frmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(789, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gboxBusqueda_Paciente);
            this.Name = "frmBuscarPaciente";
            this.Text = "frmBuscarPaciente";
            this.Load += new System.EventHandler(this.frmBuscarPaciente_Load);
            this.gboxBusqueda_Paciente.ResumeLayout(false);
            this.gboxBusqueda_Paciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource1)).EndInit();
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
        private System.Windows.Forms.RadioButton rdCedula_BP;
        private System.Windows.Forms.RadioButton rdId_BP;
        private System.Windows.Forms.TextBox txtBusqueda_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classpatientBindingSource;
        private System.Windows.Forms.BindingSource classpatientBindingSource1;
        private System.Windows.Forms.BindingSource classpatientBindingSource2;
        private System.Windows.Forms.RadioButton rdNombre_BP;
        private System.Windows.Forms.Button button1;
    }
}