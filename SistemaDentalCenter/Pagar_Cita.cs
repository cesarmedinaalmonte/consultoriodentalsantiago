using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDentalCenter
{
    public partial class Pagar_Cita : Form
    {
        conexion obconexion = new conexion();

        public Pagar_Cita()
        {
            InitializeComponent();
        }

        private void Pagar_Cita_Load(object sender, EventArgs e)
        {
            // Creamos un evento que llena automaticamente el text IDCita.
            idpaciente.Text = "";
            idpaciente.Text = Program.idpaciente.ToString();
            txtNombre.Text = Program.nombre;
            txtApellido.Text = Program.apellido;
            txtARS.Text = Program.ars;
            //txtEstado.Text = Program.estado;

            //Creando un nuevo objeto de conexion
            
            DataTable dt = obconexion.consultar2("select * from cita where fk_idpaciente="+ idpaciente.Text + " ");
            dtgv_pagarcita.DataSource = dt;
            dtgv_pagarcita.Refresh();

            
          

            //cesarconn.consultar2("select nombre, apellido, ars from paciente INNER JOIN cita ON cita.fk_idpaciente = paciente.id");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente frmpaciente = new frmBuscarPaciente();
            frmpaciente.Show();
        }

        private void IDCita_Pagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_pagarcita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int idcita_temporal = Convert.ToInt32(dtgv_pagarcita.CurrentRow.Cells[0].Value.ToString());
            txtnumerocita.Text = dtgv_pagarcita.CurrentRow.Cells[0].Value.ToString();
            txtEstado.Text  =  dtgv_pagarcita.CurrentRow.Cells[1].Value.ToString();
            conexion cesarconn = new conexion();
            DataTable dt = cesarconn.consultar2("select * from cita where fk_idpaciente=" + idpaciente.Text + " ");
          
            DataTable dt1 = cesarconn.consultar2("select * from trabajorealizados where fk_idcita = '"+idcita_temporal+"'");
            dgrvtrabajorealizados.DataSource = dt1;
            dgrvtrabajorealizados.Refresh();
            
          

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEstado.Text == "Cerrado")
                {
                    MessageBox.Show("La cita esta cerrada", "Atencion");
                }
                if (txtEstado.Text == "Abierta")
                {
                    obconexion.consultarSinResultado("UPDATE cita SET estado='Cerrado' WHERE id = '" + txtnumerocita.Text + "'");
                    dtgv_pagarcita.Refresh();
                    MessageBox.Show("Cita Pagada");


                }
                
            }
            catch (Exception ex )
            {
                MessageBox.Show("Error al pagar cita");
            }
            finally
            {
               
            }

           

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtARS.Text = "";
            txtDescuento.Text = "";
            txtnumerocita.Text = "";
            txtTotal.Text = "";
            txtEstado.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtDescuento.Text.Length != 0)
            {
                int descuento = Convert.ToInt32(txtDescuento.Text);
                int subtotal = Convert.ToInt32(dgrvtrabajorealizados.CurrentRow.Cells[2].Value.ToString());
                int total = subtotal - descuento;
                txtTotal.Text = total.ToString();

            }
            else
            {
                txtTotal.Text = dgrvtrabajorealizados.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            conexion obconexion = new conexion();
            DataSet ds = new DataSet();

            DataTable dt = obconexion.consultar2("select * from trabajorealizados");
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "trabajorealizados";


            ds.WriteXml(@"C:\\DB\facturadetalle.xml");
            frmvisor f = new frmvisor("visortrabajo.rpt");
            f.Show();

        }
    }
}
