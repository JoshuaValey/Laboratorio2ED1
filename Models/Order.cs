using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio2ED1.Models
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Nit { get; set; }
        public List<Drug> DrugList { get; set; }
        public double TotalToPay { get; set; }




    }
}