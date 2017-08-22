namespace SistemaDentalCenter
{
    partial class frmCrearTrabajo
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
            this.btnGuardar_CT = new System.Windows.Forms.Button();
            this.txtNombre_CT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar_CT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor_CT = new System.Windows.Forms.TextBox();
            this.dtgv_CT = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.rdId_CT = new System.Windows.Forms.RadioButton();
            this.txtBusqueda_CT = new System.Windows.Forms.TextBox();
            this.btnBuscar_CT = new System.Windows.Forms.Button();
            this.btnEliminar_CT = new System.Windows.Forms.Button();
            this.btnModificar_CT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classtrabajoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar_CT
            // 
            this.btnGuardar_CT.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuardar_CT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnGuardar_CT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar_CT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar_CT.Location = new System.Drawing.Point(317, 29);
            this.btnGuardar_CT.Name = "btnGuardar_CT";
            this.btnGuardar_CT.Size = new System.Drawing.Size(75, 37);
            this.btnGuardar_CT.TabIndex = 0;
            this.btnGuardar_CT.Text = "Guardar";
            this.btnGuardar_CT.UseVisualStyleBackColor = true;
            this.btnGuardar_CT.Click += new System.EventHandler(this.btnGuardar_CT_Click);
            // 
            // txtNombre_CT
            // 
            this.txtNombre_CT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre_CT.Location = new System.Drawing.Point(53, 22);
            this.txtNombre_CT.Name = "txtNombre_CT";
            this.txtNombre_CT.Size = new System.Drawing.Size(237, 20);
            this.txtNombre_CT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // btnLimpiar_CT
            // 
            this.btnLimpiar_CT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLimpiar_CT.Location = new System.Drawing.Point(408, 30);
            this.btnLimpiar_CT.Name = "btnLimpiar_CT";
            this.btnLimpiar_CT.Size = new System.Drawing.Size(75, 36);
            this.btnLimpiar_CT.TabIndex = 5;
            this.btnLimpiar_CT.Text = "Limpiar";
            this.btnLimpiar_CT.UseVisualStyleBackColor = false;
            this.btnLimpiar_CT.Click += new System.EventHandler(this.btnLimpiar_CT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor (RD$):";
            // 
            // txtValor_CT
            // 
            this.txtValor_CT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValor_CT.Location = new System.Drawing.Point(74, 65);
            this.txtValor_CT.Name = "txtValor_CT";
            this.txtValor_CT.Size = new System.Drawing.Size(145, 20);
            this.txtValor_CT.TabIndex = 6;
            // 
            // dtgv_CT
            // 
            this.dtgv_CT.AutoGenerateColumns = false;
            this.dtgv_CT.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgv_CT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dtgv_CT.DataSource = this.classtrabajoBindingSource;
            this.dtgv_CT.Location = new System.Drawing.Point(12, 187);
            this.dtgv_CT.Name = "dtgv_CT";
            this.dtgv_CT.Size = new System.Drawing.Size(536, 278);
            this.dtgv_CT.TabIndex = 16;
            this.dtgv_CT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CT_CellClick);
            this.dtgv_CT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_BT_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 350;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 150;
            // 
            // classtrabajoBindingSource
            // 
            this.classtrabajoBindingSource.DataSource = typeof(SistemaDentalCenter.Models.Class_trabajo);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(-1, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(584, 10);
            this.button3.TabIndex = 51;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // rdId_CT
            // 
            this.rdId_CT.AutoSize = true;
            this.rdId_CT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdId_CT.Location = new System.Drawing.Point(14, 153);
            this.rdId_CT.Name = "rdId_CT";
            this.rdId_CT.Size = new System.Drawing.Size(36, 19);
            this.rdId_CT.TabIndex = 52;
            this.rdId_CT.TabStop = true;
            this.rdId_CT.Text = "Id";
            this.rdId_CT.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda_CT
            // 
            this.txtBusqueda_CT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBusqueda_CT.Location = new System.Drawing.Point(12, 129);
            this.txtBusqueda_CT.Name = "txtBusqueda_CT";
            this.txtBusqueda_CT.Size = new System.Drawing.Size(235, 20);
            this.txtBusqueda_CT.TabIndex = 53;
            this.txtBusqueda_CT.TextChanged += new System.EventHandler(this.txtBusqueda_CT_TextChanged);
            // 
            // btnBuscar_CT
            // 
            this.btnBuscar_CT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar_CT.Location = new System.Drawing.Point(267, 129);
            this.btnBuscar_CT.Name = "btnBuscar_CT";
            this.btnBuscar_CT.Size = new System.Drawing.Size(83, 43);
            this.btnBuscar_CT.TabIndex = 54;
            this.btnBuscar_CT.Text = "Buscar";
            this.btnBuscar_CT.UseVisualStyleBackColor = false;
            this.btnBuscar_CT.Click += new System.EventHandler(this.btnBuscar_CT_Click);
            // 
            // btnEliminar_CT
            // 
            this.btnEliminar_CT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar_CT.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar_CT.Location = new System.Drawing.Point(466, 130);
            this.btnEliminar_CT.Name = "btnEliminar_CT";
            this.btnEliminar_CT.Size = new System.Drawing.Size(82, 43);
            this.btnEliminar_CT.TabIndex = 59;
            this.btnEliminar_CT.Text = "Eliminar";
            this.btnEliminar_CT.UseVisualStyleBackColor = false;
            this.btnEliminar_CT.Click += new System.EventHandler(this.btnEliminar_CT_Click);
            // 
            // btnModificar_CT
            // 
            this.btnModificar_CT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificar_CT.Location = new System.Drawing.Point(368, 130);
            this.btnModificar_CT.Name = "btnModificar_CT";
            this.btnModificar_CT.Size = new System.Drawing.Size(83, 44);
            this.btnModificar_CT.TabIndex = 58;
            this.btnModificar_CT.Text = "Modificar";
            this.btnModificar_CT.UseVisualStyleBackColor = false;
            this.btnModificar_CT.Click += new System.EventHandler(this.btnModificar_CT_Click);
            // 
            // frmCrearTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(583, 477);
            this.Controls.Add(this.btnEliminar_CT);
            this.Controls.Add(this.btnModificar_CT);
            this.Controls.Add(this.btnBuscar_CT);
            this.Controls.Add(this.txtBusqueda_CT);
            this.Controls.Add(this.rdId_CT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtgv_CT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor_CT);
            this.Controls.Add(this.btnLimpiar_CT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre_CT);
            this.Controls.Add(this.btnGuardar_CT);
            this.MaximizeBox = false;
            this.Name = "frmCrearTrabajo";
            this.ShowIcon = false;
            this.Text = "TRABAJO";
            this.Load += new System.EventHandler(this.frmCrearTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classtrabajoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar_CT;
        private System.Windows.Forms.TextBox txtNombre_CT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar_CT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor_CT;
        private System.Windows.Forms.DataGridView dtgv_CT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdId_CT;
        private System.Windows.Forms.TextBox txtBusqueda_CT;
        private System.Windows.Forms.Button btnBuscar_CT;
        private System.Windows.Forms.Button btnEliminar_CT;
        private System.Windows.Forms.Button btnModificar_CT;
        private System.Windows.Forms.BindingSource classtrabajoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}