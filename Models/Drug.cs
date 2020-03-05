using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio2ED1.Models
{
    public class Drug : IComparable<Drug>
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string casa_productora { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }

        /// <summary>
        /// Comapare the name of a drug with other durg.
        /// </summary>
        /// <param name="comming"></param>
        /// <returns>value betwen -1, 0 and 1.
        /// -1 if is smaller
        /// 0 if is equals
        /// 1 if is bigger</returns>
        public int CompareTo(Drug comming)
        {
            if (this.nombre.CompareTo(comming.nombre) == 1)
            {
                return 1;
            }
            else if (this.nombre.CompareTo(comming.nombre) == -1)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}