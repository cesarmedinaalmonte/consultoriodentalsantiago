using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Dapper;
using SistemaDentalCenter.Models;

namespace SistemaDentalCenter
{
    public partial class frmCrear_Cita : Form
    {
        int posicion;

        public frmCrear_Cita()

        {
            InitializeComponent();
        }

        private void frmCrear_Cita_Load(object sender, EventArgs e)
        {
            // Conectando a la base de datos
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource patient = new BindingSource();

            // Sentencia Select usando ORM DAPPER
            conn.Query<Class_patient>("Select * from paciente");
            patient.DataSource = conn.Query<Class_patient>("Select * from paciente");
            dtgvCitas_CC.DataSource = patient;
            dtgvCitas_CC.Refresh();

            // Conectando a la base de datos
            SQLiteConnection conn2 = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource trabajo = new BindingSource();

            // Sentencia Select usando ORM DAPPER
            conn.Query<Class_trabajo>("Select * from trabajorealizados");
            trabajo.DataSource = conn.Query<Class_trabajo>("Select * from trabajorealizados");
            dtgvTrabajo_CC.DataSource = trabajo;
            dtgvTrabajo_CC.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_CC_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource patient = new BindingSource();
            try
            {
                conn.Open();

                MessageBox.Show("Registro agregado!");
                //string nom = txtNombre_CC.Text;
                //DateTime fecha = dateTimePickerFecha_CC.Value.Date;
                //DateTime hora = dateTimePickerHora_CC.Value.Date;
                //string trab = txtTrabajo_CC.Text;
                //string cant = txtCantidad_CC.Text;
                string est = cboxEstado_CC.Text;
                string fkidPac = txtIDPaciente_CC.Text;
                string fkidTrab = txtTrabajo_CC.Text;



                // Codigo con Dapper
                //conn.Query<Class_patient>("insert into paciente (nombre, apellido, cedula, sexo, direccion, telefono, correo, ars) values('txtNombre_CP','txtApellido_CP','txtCedula_CP','txtSexo_CP','txtDireccion_CP','txtTelefono_CP','txtCorreo_CP','txtARS_CP')");
                //patient.DataSource = conn.Query<Class_patient>("insert into paciente (nombre, apellido, cedula, sexo, direccion, telefono, correo, ars) values('UAPA','UAPA','1122331234','F','Calle A','8099008000','uapa@uapa.edu.do','Palic')");


                //string sql = "insert into cita(nombre, tipodetrabajo, cantidad, estado) values('" + nom + "','" + trab + "','" + cant + "','" + est + "') ";

                string sql = "insert into cita(estado, fk_idpaciente, fk_idtrabajo) values('" + est + "', '" + fkidPac + "', '" + fkidTrab + "') ";
                
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dtgvCitas_CC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource patient = new BindingSource();

            conn.Query<Class_patient>("Select * from paciente");
            patient.DataSource = conn.Query<Class_patient>("Select * from paciente");
            dtgvCitas_CC.DataSource = patient;
            dtgvCitas_CC.Refresh();
        }
        
        // Inicio de busqueda de paciente
        

        private void txtBusqueda_CC_paciente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dtgvCitas_CC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // Inicio de un capturador de errores
            {

                //btnGuardar_CC.Enabled = false; // Deshabilitando el boton Guardar en el formulario Registro de Paciente 
                                               //para evitar que por error se haga click en el y se duplique el Registro de paciente 
                                               //que se manipula en la modificacion.

                posicion = dtgvCitas_CC.CurrentRow.Index; // Declaro variable posicion para capturar la posicion cuando hago click en celda dentro del DTGV.

                // Matriz para calcular los movimientos y modificar campos de paciente
                txtIDPaciente_CC.Text = dtgvCitas_CC[0, posicion].Value.ToString();
                txtNombre_CC.Text = dtgvCitas_CC[1, posicion].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            } // Fin de un capturador de errores
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource trabajo = new BindingSource();

            conn.Query<Class_trabajo>("Select * from tipodetrabajo");
            trabajo.DataSource = conn.Query<Class_trabajo>("Select * from tipodetrabajo");
            dtgvTrabajo_CC.DataSource = trabajo;
            dtgvTrabajo_CC.Refresh();
        }

        private void btnBuscar_CC_paciente_Click(object sender, EventArgs e)
        {
            //Iniciando la conexion para la busqueda de paciente
            operacion oper = new operacion();
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource centrodental = new BindingSource();

            if (txtBusqueda_CC_trabajo.Text.Length == 0)
            {
                // CODIGO NO USANDOSE... NO SE BORRA PARA FUTURO USO

                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente");
                //dtgv_BP.DataSource = dt;
                //return;

                // Sentencia Select usando ORM DAPPER

                conn.Query<Class_trabajo>("SELECT * FROM tipodetrabajo WHERE id = '" + txtBusqueda_CC_trabajo.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE id = '" + txtBusqueda_CC_trabajo.Text.Trim() + "' ");
                dtgvTrabajo_CC.DataSource = centrodental;
            }

            if (rdId_CC_Trabajo.Checked == true)

            {
                // CODIGO NO USANDOSE... NO SE BORRA PARA FUTURO USO

                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                //dtgv_BP.DataSource = dt;
                //return;

                // Sentencia Select usando ORM DAPPER

                conn.Query<Class_trabajo>("SELECT * FROM tipodetrabajo WHERE id='" + txtBusqueda_CC_trabajo.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM tipodetrabajo WHERE id='" + txtBusqueda_CC_trabajo.Text.Trim() + "' ");
                dtgvTrabajo_CC.DataSource = centrodental;

            }
        }

        private void btnModificar_CC_paciente_Click(object sender, EventArgs e)
        {

        }

        private void dtgvTrabajo_CC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // Inicio de un capturador de errores
            {

                //btnGuardar_CC.Enabled = false; // Deshabilitando el boton Guardar en el formulario Registro de Paciente 
                                               //para evitar que por error se haga click en el y se duplique el Registro de paciente 
                                               //que se manipula en la modificacion.

                posicion = dtgvTrabajo_CC.CurrentRow.Index; // Declaro variable posicion para capturar la posicion cuando hago click en celda dentro del DTGV.

                // Matriz para calcular los movimientos y modificar campos de paciente
                txtTrabajo_CC.Text = dtgvTrabajo_CC[0, posicion].Value.ToString();
                txtValor_CC.Text = dtgvTrabajo_CC[2, posicion].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            } // Fin de un capturador de errore
        }

        private void txtBusqueda_CC_trabajo_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

