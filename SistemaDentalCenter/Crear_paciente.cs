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
    public partial class Crear_paciente : Form
    {
        int posicion; // Declaro variable posicion para capturar la posicion cuando hago click en celda dentro del DTGV.

        public Crear_paciente()
        {
            InitializeComponent();
        }

        private void Crear_paciente_Load(object sender, EventArgs e)
        {
            // Conectando a la base de datos
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource patient = new BindingSource();

            // Sentencia Select usando ORM DAPPER
            conn.Query<Class_patient>("Select * from paciente");
            patient.DataSource = conn.Query<Class_patient>("Select * from paciente");
            dtgv_BP.DataSource = patient;
            dtgv_BP.Refresh();
        
        }

        private void btnGuardar_CP_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource patient = new BindingSource();
            try
            {
                conn.Open();

                MessageBox.Show("Registro agregado!");
                string nom = txtNombre_CP.Text;
                string apel = txtApellido_CP.Text;
                string ced = txtCedula_CP.Text;
                string sex = txtSexo_CP.Text;
                string dir = txtDireccion_CP.Text;
                string tel = txtTelefono_CP.Text;
                string correo = txtCorreo_CP.Text;
                string ars = txtARS_CP.Text;

                // Codigo con Dapper
                //conn.Query<Class_patient>("insert into paciente (nombre, apellido, cedula, sexo, direccion, telefono, correo, ars) values('txtNombre_CP','txtApellido_CP','txtCedula_CP','txtSexo_CP','txtDireccion_CP','txtTelefono_CP','txtCorreo_CP','txtARS_CP')");
                //patient.DataSource = conn.Query<Class_patient>("insert into paciente (nombre, apellido, cedula, sexo, direccion, telefono, correo, ars) values('UAPA','UAPA','1122331234','F','Calle A','8099008000','uapa@uapa.edu.do','Palic')");


                string sql = "insert into paciente(nombre, apellido, cedula, sexo, direccion, telefono, ars, correo) values('" + nom + "','" + apel + "','" + ced + "','" + sex + "','" + dir + "','" + tel + "','" + ars + "','" + correo + "') ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                dtgv_BP.Refresh();
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

        private void btnLimpiar_CP_Click(object sender, EventArgs e)
        {
            txtNombre_CP.Clear();
            txtApellido_CP.Clear();
            txtCedula_CP.Clear();
            txtSexo_CP.Clear();
            txtDireccion_CP.Clear();
            txtTelefono_CP.Clear();
            txtARS_CP.Clear();
            txtCorreo_CP.Clear();

            btnGuardar_CP.Enabled = true; // Habilitando el boton Guardar luego de que se modifique un paciente. Ver boton Modificar donde se ordena deshabilitar Guardar
        }

        private void btnRegresar_CP_Click(object sender, EventArgs e)
        {
            frmPantalla_Principal panpcipal = new frmPantalla_Principal();
            panpcipal.Show();
        }

        private void dtgv_BP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource patient = new BindingSource();

            conn.Query<Class_patient>("Select * from paciente");
            patient.DataSource = conn.Query<Class_patient>("Select * from paciente");
            dtgv_BP.DataSource = patient;
            dtgv_BP.Refresh();
        }

    // Inicio de busqueda de paciente
    private void txtBusqueda_paciente_TextChanged(object sender, EventArgs e)
    {


    }

        private void btnBuscar_BP_Click(object sender, EventArgs e)
        {
            //Iniciando la conexion para la busqueda de paciente
            operacion oper = new operacion();
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource centrodental = new BindingSource();

            if (txtBusqueda_paciente.Text.Length == 0)
            {
                // CODIGO NO USANDOSE... NO SE BORRA PARA FUTURO USO

                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente");
                //dtgv_BP.DataSource = dt;
                //return;

                // Sentencia Select usando ORM DAPPER

                conn.Query<Class_patient>("SELECT * FROM paciente WHERE id = '" + txtBusqueda_paciente.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE id = '" + txtBusqueda_paciente.Text.Trim() + "' ");
                dtgv_BP.DataSource = centrodental;
            }

            if (rdId_BP.Checked == true)

            {
                // CODIGO NO USANDOSE... NO SE BORRA PARA FUTURO USO

                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                //dtgv_BP.DataSource = dt;
                //return;

                // Sentencia Select usando ORM DAPPER

                conn.Query<Class_patient>("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                dtgv_BP.DataSource = centrodental;

            }
            if (rdCedula_BP.Checked == true)
            {
                // CODIGO NO USANDOSE... NO SE BORRA PARA FUTURO USO

                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE cedula='" + txtBusqueda_paciente.Text + "' ");
                //dtgv_BP.DataSource = dt;
                //return;

                // Sentencia Select usando ORM DAPPER

                conn.Query<Class_patient>("SELECT * FROM paciente WHERE cedula='" + txtBusqueda_paciente.Text + "' ");
                centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE cedula='" + txtBusqueda_paciente.Text + "' ");
                dtgv_BP.DataSource = centrodental;

            }
        }


        // Deshabilitando rdButtom al hacer click en uno de ellos como criterio de busqueda
        private void rdId_BP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdId_BP.Checked)
                rdCedula_BP.Enabled = false;

        }

        private void rdCedula_BP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCedula_BP.Checked)
                rdId_BP.Enabled = false;

        }
        // Limpiador de campos
        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda_paciente.Clear();
            rdCedula_BP.Enabled = true;
            rdId_BP.Enabled = true;
        }

        private void dtgv_BP_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            try // Inicio de un capturador de errores
            {

                btnGuardar_CP.Enabled = false; // Deshabilitando el boton Guardar en el formulario Registro de Paciente 
                                               //para evitar que por error se haga click en el y se duplique el Registro de paciente 
                                               //que se manipula en la modificacion.

            posicion = dtgv_BP.CurrentRow.Index; // Declaro variable posicion para capturar la posicion cuando hago click en celda dentro del DTGV.

                // Matriz para calcular los movimientos y modificar campos de paciente
            txtId.Text = dtgv_BP[0, posicion].Value.ToString();
            txtNombre_CP.Text = dtgv_BP[1, posicion].Value.ToString();
            txtApellido_CP.Text = dtgv_BP[2, posicion].Value.ToString();
            txtCedula_CP.Text = dtgv_BP[3, posicion].Value.ToString();
            txtSexo_CP.Text = dtgv_BP[4, posicion].Value.ToString();
            txtDireccion_CP.Text = dtgv_BP[5, posicion].Value.ToString();
            txtTelefono_CP.Text = dtgv_BP[6, posicion].Value.ToString();
            txtARS_CP.Text = dtgv_BP[7, posicion].Value.ToString();
            txtCorreo_CP.Text = dtgv_BP[8, posicion].Value.ToString();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                    } // Fin de un capturador de errores

    }

        private void btnModificar_BP_Click(object sender, EventArgs e)
        {
           

            string a, b, c, d, x, f, g, h, i; // Declaranto todos los campos de la tabla paciente como variables para cuando se quiera modificar un paciente o campo en especifico.
            a = txtId.Text;
            b = txtNombre_CP.Text;
            c = txtApellido_CP.Text;
            d = txtCedula_CP.Text;
            x = txtSexo_CP.Text;
            f = txtDireccion_CP.Text;
            g = txtTelefono_CP.Text;
            h = txtARS_CP.Text;
            i = txtCorreo_CP.Text;

            // Matriz para aplicar los cambios en cada campos cuando se quiera modificar un paciente.
            dtgv_BP[0, posicion].Value = txtId.Text;
            dtgv_BP[1, posicion].Value = txtNombre_CP.Text;
            dtgv_BP[2, posicion].Value = txtApellido_CP.Text;
            dtgv_BP[3, posicion].Value = txtCedula_CP.Text;
            dtgv_BP[4, posicion].Value = txtSexo_CP.Text;
            dtgv_BP[5, posicion].Value = txtDireccion_CP.Text;
            dtgv_BP[6, posicion].Value = txtTelefono_CP.Text;
            dtgv_BP[7, posicion].Value = txtARS_CP.Text;
            dtgv_BP[8, posicion].Value = txtCorreo_CP.Text;

        }
        // Codigo para boton eliminar paciente.
        private void btnEliminar_BP_Click(object sender, EventArgs e)
        {
            dtgv_BP.Rows.RemoveAt(posicion); // Codigo para eliminar desde DTGV mediante un RemoveAt (parametrizada)
        }
    }
}

