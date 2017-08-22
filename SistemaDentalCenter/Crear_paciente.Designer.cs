namespace SistemaDentalCenter
{
    partial class Crear_paciente
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
            this.btnGuardar_CP = new System.Windows.Forms.Button();
            this.btnLimpiar_CP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre_CP = new System.Windows.Forms.TextBox();
            this.txtCedula_CP = new System.Windows.Forms.TextBox();
            this.txtApellido_CP = new System.Windows.Forms.TextBox();
            this.txtSexo_CP = new System.Windows.Forms.TextBox();
            this.txtTelefono_CP = new System.Windows.Forms.TextBox();
            this.txtARS_CP = new System.Windows.Forms.TextBox();
            this.txtDireccion_CP = new System.Windows.Forms.TextBox();
            this.dateTimePicker_CP = new System.Windows.Forms.DateTimePicker();
            this.btnRegresar_CP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorreo_CP = new System.Windows.Forms.TextBox();
            this.dtgv_BP = new System.Windows.Forms.DataGridView();
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
            this.txtBusqueda_paciente = new System.Windows.Forms.TextBox();
            this.rdCedula_BP = new System.Windows.Forms.RadioButton();
            this.rdId_BP = new System.Windows.Forms.RadioButton();
            this.btnBuscar_BP = new System.Windows.Forms.Button();
            this.btnEliminar_BP = new System.Windows.Forms.Button();
            this.btnModificar_BP = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimpiarBuscador = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar_CP
            // 
            this.btnGuardar_CP.BackColor = System.Drawing.SystemColors.Info;
            this.btnGuardar_CP.Location = new System.Drawing.Point(65, 403);
            this.btnGuardar_CP.Name = "btnGuardar_CP";
            this.btnGuardar_CP.Size = new System.Drawing.Size(70, 33);
            this.btnGuardar_CP.TabIndex = 0;
            this.btnGuardar_CP.Text = "Guardar";
            this.btnGuardar_CP.UseVisualStyleBackColor = false;
            this.btnGuardar_CP.Click += new System.EventHandler(this.btnGuardar_CP_Click);
            // 
            // btnLimpiar_CP
            // 
            this.btnLimpiar_CP.BackColor = System.Drawing.SystemColors.Info;
            this.btnLimpiar_CP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar_CP.Location = new System.Drawing.Point(141, 403);
            this.btnLimpiar_CP.Name = "btnLimpiar_CP";
            this.btnLimpiar_CP.Size = new System.Drawing.Size(70, 33);
            this.btnLimpiar_CP.TabIndex = 1;
            this.btnLimpiar_CP.Text = "Limpiar";
            this.btnLimpiar_CP.UseVisualStyleBackColor = false;
            this.btnLimpiar_CP.Click += new System.EventHandler(this.btnLimpiar_CP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cédula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Teléfono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "ARS:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtId.Location = new System.Drawing.Point(37, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(70, 20);
            this.txtId.TabIndex = 11;
            // 
            // txtNombre_CP
            // 
            this.txtNombre_CP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre_CP.Location = new System.Drawing.Point(65, 69);
            this.txtNombre_CP.Name = "txtNombre_CP";
            this.txtNombre_CP.Size = new System.Drawing.Size(227, 20);
            this.txtNombre_CP.TabIndex = 12;
            // 
            // txtCedula_CP
            // 
            this.txtCedula_CP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCedula_CP.Location = new System.Drawing.Point(65, 141);
            this.txtCedula_CP.Name = "txtCedula_CP";
            this.txtCedula_CP.Size = new System.Drawing.Size(227, 20);
            this.txtCedula_CP.TabIndex = 13;
            // 
            // txtApellido_CP
            // 
            this.txtApellido_CP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApellido_CP.Location = new System.Drawing.Point(65, 105);
            this.txtApellido_CP.Name = "txtApellido_CP";
            this.txtApellido_CP.Size = new System.Drawing.Size(227, 20);
            this.txtApellido_CP.TabIndex = 14;
            // 
            // txtSexo_CP
            // 
            this.txtSexo_CP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSexo_CP.Location = new System.Drawing.Point(65, 176);
            this.txtSexo_CP.Name = "txtSexo_CP";
            this.txtSexo_CP.Size = new System.Drawing.Size(42, 20);
            this.txtSexo_CP.TabIndex = 15;
            // 
            // txtTelefono_CP
            // 
            this.txtTelefono_CP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefono_CP.Location = new System.Drawing.Point(65, 286);
            this.txtTelefono_CP.Name = "txtTelefono_CP";
            this.txtTelefono_CP.Size = new System.Drawing.Size(227, 20);
            this.txtTelefono_CP.TabIndex = 16;
            // 
            // txtARS_CP
            // 
            this.txtARS_CP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtARS_CP.Location = new System.Drawing.Point(65, 322);
            this.txtARS_CP.Name = "txtARS_CP";
            this.txtARS_CP.Size = new System.Drawing.Size(227, 20);
            this.txtARS_CP.TabIndex = 17;
            // 
            // txtDireccion_CP
            // 
            this.txtDireccion_CP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDireccion_CP.Location = new System.Drawing.Point(65, 245);
            this.txtDireccion_CP.Name = "txtDireccion_CP";
            this.txtDireccion_CP.Size = new System.Drawing.Size(227, 20);
            this.txtDireccion_CP.TabIndex = 18;
            // 
            // dateTimePicker_CP
            // 
            this.dateTimePicker_CP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CP.Location = new System.Drawing.Point(112, 210);
            this.dateTimePicker_CP.Name = "dateTimePicker_CP";
            this.dateTimePicker_CP.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker_CP.TabIndex = 19;
            // 
            // btnRegresar_CP
            // 
            this.btnRegresar_CP.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegresar_CP.Location = new System.Drawing.Point(217, 403);
            this.btnRegresar_CP.Name = "btnRegresar_CP";
            this.btnRegresar_CP.Size = new System.Drawing.Size(74, 33);
            this.btnRegresar_CP.TabIndex = 22;
            this.btnRegresar_CP.Text = "Regresar";
            this.btnRegresar_CP.UseVisualStyleBackColor = false;
            this.btnRegresar_CP.Click += new System.EventHandler(this.btnRegresar_CP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Correo:";
            // 
            // txtCorreo_CP
            // 
            this.txtCorreo_CP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCorreo_CP.Location = new System.Drawing.Point(65, 358);
            this.txtCorreo_CP.Name = "txtCorreo_CP";
            this.txtCorreo_CP.Size = new System.Drawing.Size(305, 20);
            this.txtCorreo_CP.TabIndex = 48;
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
            this.dtgv_BP.DataSource = this.classpatientBindingSource;
            this.dtgv_BP.Location = new System.Drawing.Point(528, 98);
            this.dtgv_BP.Name = "dtgv_BP";
            this.dtgv_BP.Size = new System.Drawing.Size(646, 348);
            this.dtgv_BP.TabIndex = 51;
            this.dtgv_BP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_BP_CellClick);
            this.dtgv_BP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_BP_CellContentClick);
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
            // txtBusqueda_paciente
            // 
            this.txtBusqueda_paciente.Location = new System.Drawing.Point(534, 47);
            this.txtBusqueda_paciente.Name = "txtBusqueda_paciente";
            this.txtBusqueda_paciente.Size = new System.Drawing.Size(249, 20);
            this.txtBusqueda_paciente.TabIndex = 52;
            this.txtBusqueda_paciente.TextChanged += new System.EventHandler(this.txtBusqueda_paciente_TextChanged);
            // 
            // rdCedula_BP
            // 
            this.rdCedula_BP.AutoSize = true;
            this.rdCedula_BP.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCedula_BP.Location = new System.Drawing.Point(589, 72);
            this.rdCedula_BP.Name = "rdCedula_BP";
            this.rdCedula_BP.Size = new System.Drawing.Size(62, 19);
            this.rdCedula_BP.TabIndex = 54;
            this.rdCedula_BP.TabStop = true;
            this.rdCedula_BP.Text = "Cédula";
            this.rdCedula_BP.UseVisualStyleBackColor = true;
            this.rdCedula_BP.CheckedChanged += new System.EventHandler(this.rdCedula_BP_CheckedChanged);
            // 
            // rdId_BP
            // 
            this.rdId_BP.AutoSize = true;
            this.rdId_BP.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdId_BP.Location = new System.Drawing.Point(534, 73);
            this.rdId_BP.Name = "rdId_BP";
            this.rdId_BP.Size = new System.Drawing.Size(36, 19);
            this.rdId_BP.TabIndex = 53;
            this.rdId_BP.TabStop = true;
            this.rdId_BP.Text = "Id";
            this.rdId_BP.UseVisualStyleBackColor = true;
            this.rdId_BP.CheckedChanged += new System.EventHandler(this.rdId_BP_CheckedChanged);
            // 
            // btnBuscar_BP
            // 
            this.btnBuscar_BP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar_BP.Location = new System.Drawing.Point(810, 57);
            this.btnBuscar_BP.Name = "btnBuscar_BP";
            this.btnBuscar_BP.Size = new System.Drawing.Size(92, 35);
            this.btnBuscar_BP.TabIndex = 55;
            this.btnBuscar_BP.Text = "Buscar";
            this.btnBuscar_BP.UseVisualStyleBackColor = false;
            this.btnBuscar_BP.Click += new System.EventHandler(this.btnBuscar_BP_Click);
            // 
            // btnEliminar_BP
            // 
            this.btnEliminar_BP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar_BP.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar_BP.Location = new System.Drawing.Point(1008, 57);
            this.btnEliminar_BP.Name = "btnEliminar_BP";
            this.btnEliminar_BP.Size = new System.Drawing.Size(105, 35);
            this.btnEliminar_BP.TabIndex = 57;
            this.btnEliminar_BP.Text = "Eliminar";
            this.btnEliminar_BP.UseVisualStyleBackColor = false;
            this.btnEliminar_BP.Click += new System.EventHandler(this.btnEliminar_BP_Click);
            // 
            // btnModificar_BP
            // 
            this.btnModificar_BP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar_BP.Location = new System.Drawing.Point(908, 57);
            this.btnModificar_BP.Name = "btnModificar_BP";
            this.btnModificar_BP.Size = new System.Drawing.Size(94, 35);
            this.btnModificar_BP.TabIndex = 56;
            this.btnModificar_BP.Text = "Modificar";
            this.btnModificar_BP.UseVisualStyleBackColor = false;
            this.btnModificar_BP.Click += new System.EventHandler(this.btnModificar_BP_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(530, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Buscador de paciente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(12, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "Registro de paciente";
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(668, 71);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(115, 23);
            this.btnLimpiarBuscador.TabIndex = 60;
            this.btnLimpiarBuscador.Text = "Limpiar buscador";
            this.btnLimpiarBuscador.UseVisualStyleBackColor = true;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(518, -5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 456);
            this.button3.TabIndex = 61;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Crear_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1179, 448);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEliminar_BP);
            this.Controls.Add(this.btnModificar_BP);
            this.Controls.Add(this.btnBuscar_BP);
            this.Controls.Add(this.rdCedula_BP);
            this.Controls.Add(this.rdId_BP);
            this.Controls.Add(this.txtBusqueda_paciente);
            this.Controls.Add(this.dtgv_BP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCorreo_CP);
            this.Controls.Add(this.btnRegresar_CP);
            this.Controls.Add(this.dateTimePicker_CP);
            this.Controls.Add(this.txtDireccion_CP);
            this.Controls.Add(this.txtARS_CP);
            this.Controls.Add(this.txtTelefono_CP);
            this.Controls.Add(this.txtSexo_CP);
            this.Controls.Add(this.txtApellido_CP);
            this.Controls.Add(this.txtCedula_CP);
            this.Controls.Add(this.txtNombre_CP);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar_CP);
            this.Controls.Add(this.btnGuardar_CP);
            this.Name = "Crear_paciente";
            this.ShowIcon = false;
            this.Text = "PACIENTE";
            this.Load += new System.EventHandler(this.Crear_paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classpatientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar_CP;
        private System.Windows.Forms.Button btnLimpiar_CP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre_CP;
        private System.Windows.Forms.TextBox txtCedula_CP;
        private System.Windows.Forms.TextBox txtApellido_CP;
        private System.Windows.Forms.TextBox txtSexo_CP;
        private System.Windows.Forms.TextBox txtTelefono_CP;
        private System.Windows.Forms.TextBox txtARS_CP;
        private System.Windows.Forms.TextBox txtDireccion_CP;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CP;
        private System.Windows.Forms.Button btnRegresar_CP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorreo_CP;
        private System.Windows.Forms.DataGridView dtgv_BP;
        private System.Windows.Forms.TextBox txtBusqueda_paciente;
        private System.Windows.Forms.RadioButton rdCedula_BP;
        private System.Windows.Forms.RadioButton rdId_BP;
        private System.Windows.Forms.Button btnBuscar_BP;
        private System.Windows.Forms.Button btnEliminar_BP;
        private System.Windows.Forms.Button btnModificar_BP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Button btnLimpiarBuscador;
        private System.Windows.Forms.Button button3;
    }
}