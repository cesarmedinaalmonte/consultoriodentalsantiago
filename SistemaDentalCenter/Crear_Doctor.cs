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
    public partial class Crear_Doctor : Form
    {
        int posicion;

        public Crear_Doctor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Realizando la conexion a la base de datos
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource doctor = new BindingSource();
            try // Inicio del capturador de errores
            {
                conn.Open();
                //
                MessageBox.Show("Registro agregado!");
                // Declarando variables
                string nom = txtNombre_CD.Text;
                string apel = txtApellido_CD.Text;
                string ced = txtCedula_CD.Text;
                string sex = txtSexo_CD.Text;
                string dir = txtDireccion_CD.Text;
                string tel = txtTelefono_CD.Text;
                string exe = txtExequatur_CD.Text;
                string correo = txtCorreo_CD.Text;

             
                // Setencia de insercion de datos a la tabla doctor en la base de datos
                string sql = "insert into doctor(nombre, apellido, cedula, sexo, direccion, telefono, exequatur, correo) values('" + nom + "','" + apel + "','" + ced + "','" + sex + "','" + dir + "','" + tel + "','" + exe + "','" + correo + "') ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                dtgv_CD.Refresh();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiador de campos o registros
            txtId_CD.Clear();
            txtNombre_CD.Clear();
            txtApellido_CD.Clear();
            txtCedula_CD.Clear();
            txtSexo_CD.Clear();
            txtDireccion_CD.Clear();
            txtTelefono_CD.Clear();
            txtCorreo_CD.Clear();
            txtExequatur_CD.Clear();

            btnGuardar_CD.Enabled = true; // Habilitando el boton Guardar luego de que se modifique un paciente. Ver boton Modificar donde se ordena deshabilitar Guardar

        }

        private void btnBuscar_CD_Click(object sender, EventArgs e)
        {
            // Llamando al objeto de conexion a la Base de datos
            operacion oper = new operacion();
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource centrodental = new BindingSource();

            // Inicio del tipo de busqueda
            if (txtBusqueda_CD.Text.Length == 0)
            {
                        // CODIGO SIN USO... NO SE BORRA PARA USO FUTURO
                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente");
                //dtgv_BP.DataSource = dt;
                //return;

                // SETENCIA DE SELECT USANDO MICRO ORM DAPPER
                conn.Query<Class_doctor>("SELECT * FROM doctor WHERE id = '" + txtBusqueda_CD.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_doctor>("SELECT * FROM doctor WHERE id = '" + txtBusqueda_CD.Text.Trim() + "' ");
                dtgv_CD.DataSource = centrodental;
            }
            //  Busqueda por radio Buttom ID

            if (rdId_CD.Checked == true)

            {
                // CODIGO SIN USO... NO SE BORRA PARA USO FUTURO

                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                //dtgv_BP.DataSource = dt;
                //return;
                conn.Query<Class_patient>("SELECT * FROM doctor WHERE id='" + txtBusqueda_CD.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_doctor>("SELECT * FROM doctor WHERE id='" + txtBusqueda_CD.Text.Trim() + "' ");
                dtgv_CD.DataSource = centrodental;

            }
            //  Busqueda por radio Buttom Cedula
            if (rdCedula_CD.Checked == true)
            {
                // CODIGO SIN USO... NO SE BORRA PARA USO FUTURO

                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE cedula='" + txtBusqueda_paciente.Text + "' ");
                //dtgv_BP.DataSource = dt;
                //return;
                conn.Query<Class_patient>("SELECT * FROM doctor WHERE cedula='" + txtBusqueda_CD.Text + "' ");
                centrodental.DataSource = conn.Query<Class_doctor>("SELECT * FROM doctor WHERE cedula='" + txtBusqueda_CD.Text + "' ");
                dtgv_CD.DataSource = centrodental;

            }
        }

        private void btnModificar_CD_Click(object sender, EventArgs e)
        {
            string a, b, c, d, x, f, g, h, i; // Declaranto todos los campos de la tabla paciente como variables para cuando se quiera modificar un paciente o campo en especifico.
            a = txtId_CD.Text;
            b = txtNombre_CD.Text;
            c = txtApellido_CD.Text;
            d = txtCedula_CD.Text;
            x = txtSexo_CD.Text;
            f = txtDireccion_CD.Text;
            g = txtTelefono_CD.Text;
            h = txtCorreo_CD.Text;
            i = txtExequatur_CD.Text;
            

            // Matriz para aplicar los cambios en cada campos cuando se quiera modificar un paciente.
            dtgv_CD[0, posicion].Value = txtId_CD.Text;
            dtgv_CD[1, posicion].Value = txtNombre_CD.Text;
            dtgv_CD[2, posicion].Value = txtApellido_CD.Text;
            dtgv_CD[3, posicion].Value = txtCedula_CD.Text;
            dtgv_CD[4, posicion].Value = txtSexo_CD.Text;
            dtgv_CD[5, posicion].Value = txtDireccion_CD.Text;
            dtgv_CD[6, posicion].Value = txtTelefono_CD.Text;
            dtgv_CD[7, posicion].Value = txtCorreo_CD.Text;
            dtgv_CD[8, posicion].Value = txtExequatur_CD.Text;
        }

        private void dtgv_CD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // Inicio de un capturador de errores
            {

                btnGuardar_CD.Enabled = false; // Deshabilitando el boton Guardar en el formulario Registro de Paciente 
                                               //para evitar que por error se haga click en el y se duplique el Registro de paciente 
                                               //que se manipula en la modificacion.

                posicion = dtgv_CD.CurrentRow.Index; // Declaro variable posicion para capturar la posicion cuando hago click en celda dentro del DTGV.

                // Matriz para calcular los movimientos y modificar campos de paciente
                txtId_CD.Text = dtgv_CD[0, posicion].Value.ToString();
                txtNombre_CD.Text = dtgv_CD[1, posicion].Value.ToString();
                txtApellido_CD.Text = dtgv_CD[2, posicion].Value.ToString();
                txtCedula_CD.Text = dtgv_CD[3, posicion].Value.ToString();
                txtSexo_CD.Text = dtgv_CD[4, posicion].Value.ToString();
                txtDireccion_CD.Text = dtgv_CD[5, posicion].Value.ToString();
                txtTelefono_CD.Text = dtgv_CD[6, posicion].Value.ToString();
                txtCorreo_CD.Text = dtgv_CD[7, posicion].Value.ToString();
                txtExequatur_CD.Text = dtgv_CD[8, posicion].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            } // Fin de un capturador de errores
        }

        private void btnEliminar_CD_Click(object sender, EventArgs e)
        {
            dtgv_CD.Rows.RemoveAt(posicion); // Codigo para eliminar desde DTGV mediante un RemoveAt (parametrizada)

        }

        // Deshabilitando los radios Buttom luego de hacer click en uno de ellos para hacer la busqueda
        private void rdId_CD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdId_CD.Checked)
                rdCedula_CD.Enabled = false; // Deshabilitando radioCedula cuando se selecciona radioID
        }

        private void rdCedula_CD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCedula_CD.Checked)
                rdId_CD.Enabled = false;
        }

        private void btnLimpiadorBusqueda_CD_Click(object sender, EventArgs e)
        {
            // Limpiador de campos
            txtBusqueda_CD.Clear();
            rdCedula_CD.Enabled = true;
            rdId_CD.Enabled = true;
            btnGuardar_CD.Enabled = true;
        }
    }
    }

