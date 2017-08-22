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
    public partial class visorpaciente : Form
    {
        private string v;

        public visorpaciente()
        {
            InitializeComponent();
        }

        public visorpaciente(string v)
        {
            this.v = v;
        }

        private void visorpaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
