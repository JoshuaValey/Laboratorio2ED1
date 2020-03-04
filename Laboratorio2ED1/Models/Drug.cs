using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio2ED1.Models
{
    public class Drug
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string casa_productora { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }
    }
}