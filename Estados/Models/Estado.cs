using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estados.Models
{
    public class Estado
    {
        public int estadoID { get; set; }
        public string estado { get; set; }

        public virtual ICollection<Municipio> municipios { get; set; }
    }
}