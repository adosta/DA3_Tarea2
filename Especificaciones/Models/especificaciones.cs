﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DA3_especificaciones.Models
{
    public class especificaciones
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string costo { get; set; }
        public string ram { get; set; }
        public string procesador { get; set; }
        public string hdd { get; set; }
        public string dimensiones { get; set; }
    }
}