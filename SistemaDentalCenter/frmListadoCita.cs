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
using System.Timers;

namespace SistemaDentalCenter
{
    public partial class frmListadoCita : Form
    {
        int posicion;

        public frmListadoCita()
        {
            InitializeComponent();
        }

        private void dtgvCitas_BC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource cita = new BindingSource();
            conexion cesarconn = new conexion();
            DataTable dt = cesarconn.consultar2("Select nombre, apellido, ars, cita.id, estado from paciente INNER JOIN cita on cita.fk_idpaciente = paciente.id ");
            dtgvCitas_BC.DataSource = dt;
            dtgvCitas_BC.Refresh();
            //conn.Query<Class_cita>("Select nombre, apellido, ars, cita.id, estado from paciente INNER JOIN cita on cita.fk_idpaciente = paciente.id ");
            //cita.DataSource = conn.Query<Class_cita>("Select nombre, apellido, ars, cita.id, estado from paciente INNER JOIN cita on cita.fk_idpaciente = paciente.id");
            //dtgvCitas_BC.DataSource = cita;
            //dtgvCitas_BC.Refresh();
        }

        private void txtBuscar_BC_TextChanged(object sender, EventArgs e)
        {
            // Conectando a la base de datos
            SQLiteConnection conn = new SQLiteConnection("Data source=C:\\DB\\ConsultorioDental.sqlite");
            BindingSource cita = new BindingSource();
            
            //conexion obconexion = new conexion();

            //DataTable dt = obconexion.consultar2("SELECT * FROM cita");
            //dtgvCitas_BC.DataSource = dt;
            //dtgvCitas_BC.Refresh();


            //Sentencia Select usando ORM DAPPER

            conn.Query<Class_cita>("Select nombre, apellido, ars, cita.id, estado, fk_idpaciente, fk_idtrabajo from paciente INNER JOIN cita on cita.fk_idpaciente = paciente.id ");
            cita.DataSource = conn.Query<Class_cita>("Select nombre, apellido, ars, cita.id, estado, fk_idpaciente, fk_idtrabajo from paciente INNER JOIN cita on cita.fk_idpaciente = paciente.id ");
            dtgvCitas_BC.DataSource = cita;
            dtgvCitas_BC.Refresh();

        }

        
        private void dtgvCitas_BC_DoubleClick(object sender, EventArgs e)
        {
            Program.nombre = dtgvCitas_BC.CurrentRow.Cells[0].Value.ToString();
            Program.apellido = dtgvCitas_BC.CurrentRow.Cells[1].Value.ToString();
            Program.ars = dtgvCitas_BC.CurrentRow.Cells[2].Value.ToString();
            Program.estado = dtgvCitas_BC.CurrentRow.Cells[3].Value.ToString();
            Program.idcita =  Convert.ToInt32(dtgvCitas_BC.CurrentRow.Cells[4].Value.ToString());
            Program.idpaciente = Convert.ToInt32(dtgvCitas_BC.CurrentRow.Cells[5].Value.ToString());
            Program.idtrabajo = Convert.ToInt32(dtgvCitas_BC.CurrentRow.Cells[6].Value.ToString());
         


            this.Close();

        }

        private void dtgvCitas_BC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
