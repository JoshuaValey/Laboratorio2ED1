using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Laboratorio2ED1.Helpers;
using Laboratorio2ED1.Models;
using System.IO;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = Console.ReadLine();
            StreamReader json = new StreamReader(filepath);
            string jsons = json.ReadToEnd();
            jsons = jsons.Replace("null", "0");
            Drug[] JsonArray = JsonConvert.DeserializeObject<Drug[]>(jsons);
            foreach (var item in JsonArray)
            {
                Storage.Instance.drugsList.Add(item);
            }
        }
    }
}
