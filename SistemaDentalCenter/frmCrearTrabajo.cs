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
    public partial class frmCrearTrabajo : Form
    {
        int posicion; // Declaro variable para capturar celda al momento de ahcer click en DTGV

        public frmCrearTrabajo()
        {
            InitializeComponent();
        }

        private void dtgv_BT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource trabajo = new BindingSource();

            conn.Query<Class_trabajo>("Select * from tipodetrabajo");
            trabajo.DataSource = conn.Query<Class_trabajo>("Select * from tipodetrabajo");
            dtgv_CT.DataSource = trabajo;
            dtgv_CT.Refresh();
        }

        private void btnGuardar_CT_Click(object sender, EventArgs e)
        {
            //creando objeto de conexion a la base de datos
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource trabajo = new BindingSource();
            try // Inicio del capturado de error 
            {
                conn.Open();

                MessageBox.Show("Registro agregado!");

                //declarando los txt de crear Trabajo
                string nom = txtNombre_CT.Text;
                string valor = txtValor_CT.Text;

                // Sentencia que inserta los datos de nuevos tipos de trabajos creados
                string sql = "insert into tipodetrabajo(nombre, valor) values('" + nom + "','" + valor + "') ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                dtgv_CT.Refresh();
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

        // Codigo para limpiar los textbox correspondente al FARM crear trabajo.
        private void btnLimpiar_CT_Click(object sender, EventArgs e)
        {
            txtValor_CT.Clear();
            txtNombre_CT.Clear();

            btnGuardar_CT.Enabled = true; // HAbilitando el boton Guardar que habia sido deshabilitado mediante el boton Modificar. 
        }

        private void txtBusqueda_CT_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnBuscar_CT_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion(); //Preparando la conexion a la base de datos
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource centrodental = new BindingSource();

            if (txtBusqueda_CT.Text.Length == 0)
            {
                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente");
                //dtgv_BP.DataSource = dt;
                //return;

                conn.Query<Class_trabajo>("SELECT * FROM tipodetrabajo WHERE id = '" + txtBusqueda_CT.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_trabajo>("SELECT * FROM tipodetrabajo WHERE id = '" + txtBusqueda_CT.Text.Trim() + "' ");
                dtgv_CT.DataSource = centrodental;
            }

            if (rdId_CT.Checked == true)

            {
                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                //dtgv_BP.DataSource = dt;
                //return;
                conn.Query<Class_trabajo>("SELECT * FROM tipodetrabajo WHERE id='" + txtBusqueda_CT.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_trabajo>("SELECT * FROM tipodetrabajo WHERE id='" + txtBusqueda_CT.Text.Trim() + "' ");
                dtgv_CT.DataSource = centrodental;
            }
        }

        private void dtgv_CT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dtgv_CT.CurrentRow.Index;
            try // Inicio de un capturador de errores
            {

                btnGuardar_CT.Enabled = false; // Deshabilitando el boton Guardar en el formulario Registro de Paciente 
                                               //para evitar que por error se haga click en el y se duplique el Registro de paciente 
                                               //que se manipula en la modificacion.

                posicion = dtgv_CT.CurrentRow.Index; // Declaro variable posicion para capturar la posicion cuando hago click en celda dentro del DTGV.

                // Matriz para calcular los movimientos y modificar campos de paciente
                
                txtNombre_CT.Text = dtgv_CT[1, posicion].Value.ToString();
                txtValor_CT.Text = dtgv_CT[2, posicion].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            } // Fin de un capturador de errores
        }

        private void btnModificar_CT_Click(object sender, EventArgs e)
        {
            string a, b; // Declaranto todos los campos de la tabla tipodetrabajo como variables para cuando se quiera modificar un paciente o campo en especifico.
            
            a = txtNombre_CT.Text;
            b = txtValor_CT.Text;
           

            // Matriz para aplicar los cambios en cada campos cuando se quiera modificar un paciente.
            
            dtgv_CT[1, posicion].Value = txtNombre_CT.Text;
            dtgv_CT[2, posicion].Value = txtValor_CT.Text;
        
        }

        // Codigo para boton eliminar paciente.

        private void btnEliminar_CT_Click(object sender, EventArgs e)
        {
            dtgv_CT.Rows.RemoveAt(posicion); // Codigo para eliminar desde DTGV mediante un RemoveAt (parametrizada)

        }

        private void frmCrearTrabajo_Load(object sender, EventArgs e)
        {
            //Conexion a la base de datos_ creando el objeto de conexion
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource trabajo = new BindingSource(); // Indicando la fuente de origen o de control de los datos.

            // Consulta Select haciendo uso del micro ORM Dapper.

            conn.Query<Class_trabajo>("Select * from tipodetrabajo");
            trabajo.DataSource = conn.Query<Class_trabajo>("Select * from tipodetrabajo");
            dtgv_CT.DataSource = trabajo;
            dtgv_CT.Refresh();
        }
    }
}

