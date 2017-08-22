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
    public partial class frmBuscarPaciente : Form
    {
        int posicion; // Declaro variable posicion para capturar la posicion cuando hago click en celda dentro del DTGV.

        public frmBuscarPaciente()
        {
            InitializeComponent();
        }

        private void btnCrearNuevo_BP_Click(object sender, EventArgs e)
        {

        }

       

        private void gboxBusqueda_Paciente_Enter(object sender, EventArgs e)
        {


            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource patient = new BindingSource();

            conn.Query<Class_patient>("Select * from paciente");
            patient.DataSource = conn.Query<Class_patient>("Select * from paciente");
            dtgv_BP.DataSource = patient;
            dtgv_BP.Refresh();


            //DataTable dt =  conn.consultar2("Select * from paciente");
            //dtgv_BP.DataSource = dt;
            //dtgv_BP.Refresh();


        }

        private void btnBuscar_BP_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource centrodental = new BindingSource();

            if (txtBusqueda_paciente.Text.Length == 0)
            {
                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente");
                //dtgv_BP.DataSource = dt;
                //return;

                conn.Query<Class_patient>("SELECT * FROM paciente WHERE id = '" + txtBusqueda_paciente.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE id = '" + txtBusqueda_paciente.Text.Trim() + "' ");
                dtgv_BP.DataSource = centrodental;

            }

            if (rdId_BP.Checked == true)
                
            {
                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                //dtgv_BP.DataSource = dt;
                //return;
                conn.Query<Class_patient>("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
                dtgv_BP.DataSource = centrodental;

            }
            if (rdCedula_BP.Checked == true)
            {
                //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE cedula='" + txtBusqueda_paciente.Text + "' ");
                //dtgv_BP.DataSource = dt;
                //return;
                conn.Query<Class_patient>("SELECT * FROM paciente WHERE cedula='" + txtBusqueda_paciente.Text + "' ");
                centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE cedula='" + txtBusqueda_paciente.Text + "' ");
                dtgv_BP.DataSource = centrodental;

            }
            //if (rdNombre_BP.Checked == true)
            //{
            //    //DataTable dt = oper.Consultaconresultado("Select * from paciente where nombre like '%" + txtBusqueda_paciente + "%' ");
            //    //dtgv_BP.DataSource = dt;
            //    //return;
            //    conn.Query<Class_patient>("Select * from paciente where nombre like '%" + txtBusqueda_paciente + "%' ");
            //    centrodental.DataSource = conn.Query<Class_patient>("Select * from paciente where nombre like '%" + txtBusqueda_paciente + "%' ");
            //    dtgv_BP.DataSource = centrodental;
            //}

        }

        private void rdId_BP_CheckedChanged(object sender, EventArgs e)
        {
            if(rdId_BP.Checked)
                rdCedula_BP.Enabled = false;
            rdNombre_BP.Enabled = false;
        }

        private void rdCedula_BP_CheckedChanged(object sender, EventArgs e)
        {
            if(rdCedula_BP.Checked)
                rdId_BP.Enabled = false;
            rdNombre_BP.Enabled = false;
        }

        private void rdNombre_BP_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNombre_BP.Checked)
                rdCedula_BP.Enabled = false;
                rdId_BP.Enabled = false;
        }

        private void dtgv_BP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //posicion = dtgv_BP.CurrentRow.Index;
            //MessageBox.Show("Celda seleccionada es la", "" + posicion);
        }

        private void dtgv_BP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtgv_BP_DoubleClick(object sender, EventArgs e)
        {
            Program.idpaciente = Convert.ToInt32(dtgv_BP.CurrentRow.Cells[0].Value.ToString());
            Program.nombre = dtgv_BP.CurrentRow.Cells[1].Value.ToString();
            Program.apellido = dtgv_BP.CurrentRow.Cells[2].Value.ToString();
            Program.ars = dtgv_BP.CurrentRow.Cells[7].Value.ToString();
            this.Close();
            
            
          
            
        }

        private void frmBuscarPaciente_Load(object sender, EventArgs e)
        {

        }
    }
    }

