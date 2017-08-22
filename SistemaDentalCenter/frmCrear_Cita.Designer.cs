namespace SistemaDentalCenter
{
    partial class frmCrear_Cita
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
            this.dateTimePickerFecha_CC = new System.Windows.Forms.DateTimePicker();
            this.txtIDPaciente_CC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar_CC = new System.Windows.Forms.Button();
            this.btnGuardar_CC = new System.Windows.Forms.Button();
            this.dateTimePickerHora_CC = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvCitas_CC = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classpatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTrabajo_CC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre_CC = new System.Windows.Forms.TextBox();
            this.txtCantidad_CC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvTrabajo_CC = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimpiar_CC_BuscadorPaciente = new System.Windows.Forms.Button();
            this.btnModificar_CC_paciente = new System.Windows.Forms.Button();
            this.btnBuscar_CC_paciente = new System.Windows.Forms.Button();
            this.rdId_CC_paciente = new System.Windows.Forms.RadioButton();
            this.txtBusqueda_CC_paciente = new System.Windows.Forms.TextBox();
            this.btnLimpiar_CC_Buscador_trabajo = new System.Windows.Forms.Button();
            this.btnModificar_CC_Trabajo = new System.Windows.Forms.Button();
            this.btnBuscar_CC_Trabajo = new System.Windows.Forms.Button();
            this.rdId_CC_Trabajo = new System.Windows.Forms.RadioButton();
            this.txtBusqueda_CC_trabajo = new System.Windows.Forms.TextBox();
            this.cboxEstado_CC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor_CC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.classtrabajoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fk_idcita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCitas_CC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrabajo_CC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classtrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classtrabajoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFecha_CC
            // 
            this.dateTimePickerFecha_CC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFecha_CC.Location = new System.Drawing.Point(69, 60);
            this.dateTimePickerFecha_CC.Name = "dateTimePickerFecha_CC";
            this.dateTimePickerFecha_CC.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerFecha_CC.TabIndex = 42;
            // 
            // txtIDPaciente_CC
            // 
            this.txtIDPaciente_CC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIDPaciente_CC.Location = new System.Drawing.Point(70, 23);
            this.txtIDPaciente_CC.Name = "txtIDPaciente_CC";
            this.txtIDPaciente_CC.Size = new System.Drawing.Size(57, 20);
            this.txtIDPaciente_CC.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Trabajos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fecha cita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // btnLimpiar_CC
            // 
            this.btnLimpiar_CC.BackColor = System.Drawing.SystemColors.Info;
            this.btnLimpiar_CC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar_CC.Location = new System.Drawing.Point(348, 142);
            this.btnLimpiar_CC.Name = "btnLimpiar_CC";
            this.btnLimpiar_CC.Size = new System.Drawing.Size(57, 26);
            this.btnLimpiar_CC.TabIndex = 24;
            this.btnLimpiar_CC.Text = "Limpiar";
            this.btnLimpiar_CC.UseVisualStyleBackColor = false;
            // 
            // btnGuardar_CC
            // 
            this.btnGuardar_CC.BackColor = System.Drawing.SystemColors.Info;
            this.btnGuardar_CC.Location = new System.Drawing.Point(284, 142);
            this.btnGuardar_CC.Name = "btnGuardar_CC";
            this.btnGuardar_CC.Size = new System.Drawing.Size(58, 28);
            this.btnGuardar_CC.TabIndex = 23;
            this.btnGuardar_CC.Text = "Guardar";
            this.btnGuardar_CC.UseVisualStyleBackColor = false;
            this.btnGuardar_CC.Click += new System.EventHandler(this.btnGuardar_CC_Click);
            // 
            // dateTimePickerHora_CC
            // 
            this.dateTimePickerHora_CC.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora_CC.Location = new System.Drawing.Point(212, 60);
            this.dateTimePickerHora_CC.Name = "dateTimePickerHora_CC";
            this.dateTimePickerHora_CC.Size = new System.Drawing.Size(86, 20);
            this.dateTimePickerHora_CC.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Hora:";
            // 
            // dtgvCitas_CC
            // 
            this.dtgvCitas_CC.AutoGenerateColumns = false;
            this.dtgvCitas_CC.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgvCitas_CC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCitas_CC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.arsDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dtgvCitas_CC.DataSource = this.classpatientBindingSource;
            this.dtgvCitas_CC.Location = new System.Drawing.Point(6, 237);
            this.dtgvCitas_CC.Name = "dtgvCitas_CC";
            this.dtgvCitas_CC.Size = new System.Drawing.Size(398, 143);
            this.dtgvCitas_CC.TabIndex = 52;
            this.dtgvCitas_CC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCitas_CC_CellClick);
            this.dtgvCitas_CC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCitas_CC_CellContentClick);
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
            // classpatientBindingSource
            // 
            this.classpatientBindingSource.DataSource = typeof(SistemaDentalCenter.Models.Class_patient);
            // 
            // txtTrabajo_CC
            // 
            this.txtTrabajo_CC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTrabajo_CC.Location = new System.Drawing.Point(70, 112);
            this.txtTrabajo_CC.Name = "txtTrabajo_CC";
            this.txtTrabajo_CC.Size = new System.Drawing.Size(335, 20);
            this.txtTrabajo_CC.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID Paciente:";
            // 
            // txtNombre_CC
            // 
            this.txtNombre_CC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre_CC.Location = new System.Drawing.Point(188, 23);
            this.txtNombre_CC.Name = "txtNombre_CC";
            this.txtNombre_CC.Size = new System.Drawing.Size(216, 20);
            this.txtNombre_CC.TabIndex = 56;
            // 
            // txtCantidad_CC
            // 
            this.txtCantidad_CC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCantidad_CC.Location = new System.Drawing.Point(72, 143);
            this.txtCantidad_CC.Name = "txtCantidad_CC";
            this.txtCantidad_CC.Size = new System.Drawing.Size(29, 20);
            this.txtCantidad_CC.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cantidad:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(-3, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(421, 11);
            this.button3.TabIndex = 59;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(-3, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 11);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtgvTrabajo_CC
            // 
            this.dtgvTrabajo_CC.AutoGenerateColumns = false;
            this.dtgvTrabajo_CC.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgvTrabajo_CC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTrabajo_CC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.valorDataGridViewTextBoxColumn,
            this.fk_idcita});
            this.dtgvTrabajo_CC.DataSource = this.classtrabajoBindingSource1;
            this.dtgvTrabajo_CC.Location = new System.Drawing.Point(6, 456);
            this.dtgvTrabajo_CC.Name = "dtgvTrabajo_CC";
            this.dtgvTrabajo_CC.Size = new System.Drawing.Size(398, 143);
            this.dtgvTrabajo_CC.TabIndex = 61;
            this.dtgvTrabajo_CC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTrabajo_CC_CellClick);
            this.dtgvTrabajo_CC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // classtrabajoBindingSource
            // 
            this.classtrabajoBindingSource.DataSource = typeof(SistemaDentalCenter.Models.Class_trabajo);
            // 
            // btnLimpiar_CC_BuscadorPaciente
            // 
            this.btnLimpiar_CC_BuscadorPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar_CC_BuscadorPaciente.Location = new System.Drawing.Point(48, 208);
            this.btnLimpiar_CC_BuscadorPaciente.Name = "btnLimpiar_CC_BuscadorPaciente";
            this.btnLimpiar_CC_BuscadorPaciente.Size = new System.Drawing.Size(115, 23);
            this.btnLimpiar_CC_BuscadorPaciente.TabIndex = 67;
            this.btnLimpiar_CC_BuscadorPaciente.Text = "Limpiar buscador";
            this.btnLimpiar_CC_BuscadorPaciente.UseVisualStyleBackColor = true;
            // 
            // btnModificar_CC_paciente
            // 
            this.btnModificar_CC_paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar_CC_paciente.Location = new System.Drawing.Point(310, 186);
            this.btnModificar_CC_paciente.Name = "btnModificar_CC_paciente";
            this.btnModificar_CC_paciente.Size = new System.Drawing.Size(94, 35);
            this.btnModificar_CC_paciente.TabIndex = 66;
            this.btnModificar_CC_paciente.Text = "Modificar";
            this.btnModificar_CC_paciente.UseVisualStyleBackColor = false;
            this.btnModificar_CC_paciente.Click += new System.EventHandler(this.btnModificar_CC_paciente_Click);
            // 
            // btnBuscar_CC_paciente
            // 
            this.btnBuscar_CC_paciente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar_CC_paciente.Location = new System.Drawing.Point(206, 186);
            this.btnBuscar_CC_paciente.Name = "btnBuscar_CC_paciente";
            this.btnBuscar_CC_paciente.Size = new System.Drawing.Size(92, 35);
            this.btnBuscar_CC_paciente.TabIndex = 65;
            this.btnBuscar_CC_paciente.Text = "Buscar";
            this.btnBuscar_CC_paciente.UseVisualStyleBackColor = false;
            this.btnBuscar_CC_paciente.Click += new System.EventHandler(this.btnBuscar_CC_paciente_Click);
            // 
            // rdId_CC_paciente
            // 
            this.rdId_CC_paciente.AutoSize = true;
            this.rdId_CC_paciente.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdId_CC_paciente.Location = new System.Drawing.Point(6, 212);
            this.rdId_CC_paciente.Name = "rdId_CC_paciente";
            this.rdId_CC_paciente.Size = new System.Drawing.Size(36, 19);
            this.rdId_CC_paciente.TabIndex = 63;
            this.rdId_CC_paciente.TabStop = true;
            this.rdId_CC_paciente.Text = "Id";
            this.rdId_CC_paciente.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda_CC_paciente
            // 
            this.txtBusqueda_CC_paciente.Location = new System.Drawing.Point(6, 186);
            this.txtBusqueda_CC_paciente.Name = "txtBusqueda_CC_paciente";
            this.txtBusqueda_CC_paciente.Size = new System.Drawing.Size(157, 20);
            this.txtBusqueda_CC_paciente.TabIndex = 62;
            this.txtBusqueda_CC_paciente.TextChanged += new System.EventHandler(this.txtBusqueda_CC_paciente_TextChanged);
            // 
            // btnLimpiar_CC_Buscador_trabajo
            // 
            this.btnLimpiar_CC_Buscador_trabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar_CC_Buscador_trabajo.Location = new System.Drawing.Point(48, 431);
            this.btnLimpiar_CC_Buscador_trabajo.Name = "btnLimpiar_CC_Buscador_trabajo";
            this.btnLimpiar_CC_Buscador_trabajo.Size = new System.Drawing.Size(115, 23);
            this.btnLimpiar_CC_Buscador_trabajo.TabIndex = 72;
            this.btnLimpiar_CC_Buscador_trabajo.Text = "Limpiar buscador";
            this.btnLimpiar_CC_Buscador_trabajo.UseVisualStyleBackColor = true;
            // 
            // btnModificar_CC_Trabajo
            // 
            this.btnModificar_CC_Trabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar_CC_Trabajo.Location = new System.Drawing.Point(310, 409);
            this.btnModificar_CC_Trabajo.Name = "btnModificar_CC_Trabajo";
            this.btnModificar_CC_Trabajo.Size = new System.Drawing.Size(94, 35);
            this.btnModificar_CC_Trabajo.TabIndex = 71;
            this.btnModificar_CC_Trabajo.Text = "Modificar";
            this.btnModificar_CC_Trabajo.UseVisualStyleBackColor = false;
            // 
            // btnBuscar_CC_Trabajo
            // 
            this.btnBuscar_CC_Trabajo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar_CC_Trabajo.Location = new System.Drawing.Point(206, 409);
            this.btnBuscar_CC_Trabajo.Name = "btnBuscar_CC_Trabajo";
            this.btnBuscar_CC_Trabajo.Size = new System.Drawing.Size(92, 35);
            this.btnBuscar_CC_Trabajo.TabIndex = 70;
            this.btnBuscar_CC_Trabajo.Text = "Buscar";
            this.btnBuscar_CC_Trabajo.UseVisualStyleBackColor = false;
            // 
            // rdId_CC_Trabajo
            // 
            this.rdId_CC_Trabajo.AutoSize = true;
            this.rdId_CC_Trabajo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdId_CC_Trabajo.Location = new System.Drawing.Point(6, 435);
            this.rdId_CC_Trabajo.Name = "rdId_CC_Trabajo";
            this.rdId_CC_Trabajo.Size = new System.Drawing.Size(36, 19);
            this.rdId_CC_Trabajo.TabIndex = 69;
            this.rdId_CC_Trabajo.TabStop = true;
            this.rdId_CC_Trabajo.Text = "Id";
            this.rdId_CC_Trabajo.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda_CC_trabajo
            // 
            this.txtBusqueda_CC_trabajo.Location = new System.Drawing.Point(6, 409);
            this.txtBusqueda_CC_trabajo.Name = "txtBusqueda_CC_trabajo";
            this.txtBusqueda_CC_trabajo.Size = new System.Drawing.Size(157, 20);
            this.txtBusqueda_CC_trabajo.TabIndex = 68;
            this.txtBusqueda_CC_trabajo.TextChanged += new System.EventHandler(this.txtBusqueda_CC_trabajo_TextChanged);
            // 
            // cboxEstado_CC
            // 
            this.cboxEstado_CC.FormattingEnabled = true;
            this.cboxEstado_CC.Items.AddRange(new object[] {
            "Abierto",
            "Pagar",
            "Pagado"});
            this.cboxEstado_CC.Location = new System.Drawing.Point(70, 85);
            this.cboxEstado_CC.Name = "cboxEstado_CC";
            this.cboxEstado_CC.Size = new System.Drawing.Size(84, 21);
            this.cboxEstado_CC.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Estado:";
            // 
            // txtValor_CC
            // 
            this.txtValor_CC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValor_CC.Location = new System.Drawing.Point(175, 143);
            this.txtValor_CC.Name = "txtValor_CC";
            this.txtValor_CC.Size = new System.Drawing.Size(57, 20);
            this.txtValor_CC.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Valor: RD$";
            // 
            // classtrabajoBindingSource1
            // 
            this.classtrabajoBindingSource1.DataSource = typeof(SistemaDentalCenter.Models.Class_trabajo);
            // 
            // fk_idcita
            // 
            this.fk_idcita.DataPropertyName = "fk_idcita";
            this.fk_idcita.HeaderText = "fk_idcita";
            this.fk_idcita.Name = "fk_idcita";
            // 
            // frmCrear_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(416, 611);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor_CC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxEstado_CC);
            this.Controls.Add(this.btnLimpiar_CC_Buscador_trabajo);
            this.Controls.Add(this.btnModificar_CC_Trabajo);
            this.Controls.Add(this.btnBuscar_CC_Trabajo);
            this.Controls.Add(this.rdId_CC_Trabajo);
            this.Controls.Add(this.txtBusqueda_CC_trabajo);
            this.Controls.Add(this.btnLimpiar_CC_BuscadorPaciente);
            this.Controls.Add(this.btnModificar_CC_paciente);
            this.Controls.Add(this.btnBuscar_CC_paciente);
            this.Controls.Add(this.rdId_CC_paciente);
            this.Controls.Add(this.txtBusqueda_CC_paciente);
            this.Controls.Add(this.dtgvTrabajo_CC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad_CC);
            this.Controls.Add(this.txtNombre_CC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrabajo_CC);
            this.Controls.Add(this.dtgvCitas_CC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickerHora_CC);
            this.Controls.Add(this.dateTimePickerFecha_CC);
            this.Controls.Add(this.txtIDPaciente_CC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar_CC);
            this.Controls.Add(this.btnGuardar_CC);
            this.MaximizeBox = false;
            this.Name = "frmCrear_Cita";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CITA";
            this.Load += new System.EventHandler(this.frmCrear_Cita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCitas_CC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTrabajo_CC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classtrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classtrabajoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha_CC;
        private System.Windows.Forms.TextBox txtIDPaciente_CC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar_CC;
        private System.Windows.Forms.Button btnGuardar_CC;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora_CC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvCitas_CC;
        private System.Windows.Forms.TextBox txtTrabajo_CC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre_CC;
        private System.Windows.Forms.TextBox txtCantidad_CC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvTrabajo_CC;
        private System.Windows.Forms.Button btnLimpiar_CC_BuscadorPaciente;
        private System.Windows.Forms.Button btnModificar_CC_paciente;
        private System.Windows.Forms.Button btnBuscar_CC_paciente;
        private System.Windows.Forms.RadioButton rdId_CC_paciente;
        private System.Windows.Forms.TextBox txtBusqueda_CC_paciente;
        private System.Windows.Forms.Button btnLimpiar_CC_Buscador_trabajo;
        private System.Windows.Forms.Button btnModificar_CC_Trabajo;
        private System.Windows.Forms.Button btnBuscar_CC_Trabajo;
        private System.Windows.Forms.RadioButton rdId_CC_Trabajo;
        private System.Windows.Forms.TextBox txtBusqueda_CC_trabajo;
        private System.Windows.Forms.ComboBox cboxEstado_CC;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classtrabajoBindingSource;
        private System.Windows.Forms.TextBox txtValor_CC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idcita;
        private System.Windows.Forms.BindingSource classtrabajoBindingSource1;
    }
}