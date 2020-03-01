using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio2ED1.Models
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductHouse { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}