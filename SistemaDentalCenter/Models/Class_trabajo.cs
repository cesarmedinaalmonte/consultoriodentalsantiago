﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDentalCenter.Models
{
    public class Class_trabajo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string valor { get; set; }
        public string fk_idcita { get; set; }
        
    }
}
