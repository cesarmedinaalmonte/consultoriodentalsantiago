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
    public partial class frmPantalla_Principal : Form
    {
        public frmPantalla_Principal()
        {
            

            InitializeComponent();
            
        }
        // Modulo de cita
        private void buscarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrear_Cita frmcita = new frmCrear_Cita();
            frmcita.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ajustando el tamano al windows form al cargar o ejecutarse
            this.AutoScaleDimensions = new System.Drawing.SizeF(100F, 110F);
            this.PerformAutoScale();
           
        }
        // // Modulo de Paciente
        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente frm_BP = new frmBuscarPaciente();
            frm_BP.Show();
                
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdId_BP_CheckedChanged(object sender, EventArgs e)
        {

        }
        // // Llamando al formulario de crear nuevo paciente
        private void button2_Click(object sender, EventArgs e)
        {
            Crear_paciente crearnuevo = new Crear_paciente();
            crearnuevo.Show();
        }

        // Codigo fuera de uso... No lo borro para uso futuro
        private void btnBuscar_BP_Click(object sender, EventArgs e)
        { }
            ////operacion oper = new operacion();
            //SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\centrodental.sqlite");
            //BindingSource centrodental = new BindingSource();

            //if (txtBusqueda_paciente.Text.Length==0)
            //{
            //    //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente");
            //    //dtgv_BP.DataSource = dt;
            //    //return;

            //conn.Query<Class_patient>("SELECT * FROM paciente WHERE id = '" + txtBusqueda_paciente.Text.Trim() + "' ");
            //  centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE id = '" + txtBusqueda_paciente.Text.Trim() + "' ");
            //    dtgv_BP.DataSource = centrodental;

            //}

            //if (rdId_BP.Checked==true)
            //    {
            //    //    DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
            //    //dtgv_BP.DataSource = dt;
            //    //return;
            //    conn.Query<Class_patient>("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
            //    centrodental.DataSource = conn.Query<Class_patient>("SELECT * FROM paciente WHERE id='" + txtBusqueda_paciente.Text.Trim() + "' ");
            //    dtgv_BP.DataSource = centrodental;

            //}
            //if (rdCedula_BP.Checked == true)
            //{
            //    //DataTable dt = oper.Consultaconresultado("SELECT * FROM paciente WHERE cedula='" + txtBusqueda_paciente.Text + "' ");
            //    //dtgv_BP.DataSource = dt;
            //    //return;

            ////}
            ////if (rdNombre_BP.Checked == true)
            //{
            //    //DataTable dt = oper.Consultaconresultado("Select * from paciente where nombre like '%" + txtBusqueda_paciente + "%' ");
            //    //dtgv_BP.DataSource = dt;
            //    //return;
            //}
       
            //}

            //salieendo de busqueda de paciente
        private void lblCierre_BP_Click(object sender, EventArgs e)
        {
            //gboxBusqueda_Paciente.Hide();
        }
        // Llamando el formulario de doctor
        private void buscarDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_Doctor frmCD = new Crear_Doctor();
            frmCD.Show();
        }
        // Revision de programacion
        private void btnEliminar_BP_Click(object sender, EventArgs e)
        {

        }
        // El peor trabajo de mi haber estudiantil
        private void gboxBusqueda_Paciente_Enter(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_paciente_TextChanged(object sender, EventArgs e)
        {
        }
        //    operacion oper = new operacion();

        //    if (rdId_BP.Checked == true)
        //    {
        //        DataTable dt = oper.Consultaconresultado("Select * from paciente where id='" + txtBusqueda_paciente + "' ");
        //        dtgv_BP.DataSource = dt;
        //        return;
        //    }
        //}

        private void crearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamando el formulario de paciente_Crear paciente
            Crear_paciente frm_CP = new Crear_paciente();
            frm_CP.Show();
        }
        // verificacion de proyecto final
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrando el sistema desde dentro de cualquiera de los modulos
            Application.Exit();
        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearTrabajo frmCT = new frmCrearTrabajo();
            frmCT.Show();
        }

        private void visorDeCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoCita frmCita = new frmListadoCita();
            frmCita.Show();
        }

        private void pagarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagar_Cita pagocita = new Pagar_Cita();
            pagocita.Show();
        }
    }
    }

