using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDentalCenter.Models
{
    public class Class_cita
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ars { get; set; }
        public string estado { get; set; }
        public int id { get; set; }
        public string fk_idpaciente { get; set; }
        public string fk_idtrabajo { get; set; }
  
      
        

    }
}
