using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmvisor : Form
    {
        public frmvisor(String nombre_reporte)
        {
            InitializeComponent();
            
        
            InitializeComponent();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(nombre_reporte);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
