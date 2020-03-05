using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio2ED1.Models
{
    public class DrugIndex: IComparable<DrugIndex>
    {
        public int stock { get; set; }
        public string nombre  { get; set; }
        public int id { get; set; }

        /// <summary>
        /// Comapare the name of a drug with other durg.
        /// </summary>
        /// <param name="comming"></param>
        /// <returns>value betwen -1, 0 and 1.
        /// -1 if is smaller
        /// 0 if is equals
        /// 1 if is bigger</returns>
        public int CompareTo(DrugIndex comming)
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