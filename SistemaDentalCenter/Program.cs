using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDentalCenter
{
    static class Program
    {
        // Crrando variables para el evento DoubleClick desde el formulario Listado de Cita para que se llene campos en Pagar cita.
        public static int idcita;
        public static int idpaciente;
        public static int idtrabajo;
        public static string estado;
        public static string nombre;
        public static string apellido;
        public static string ars;






        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPantalla_Principal());
        }
    }
}
