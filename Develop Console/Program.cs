using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio2ED1.Helpers;
using CustomGenerics.Structures;
//libreria de jsons
using Newtonsoft.Json;
namespace Develop_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //acceder al archivo
            var ruta = Console.ReadLine();
            //lector de archivo
            var reader = new StreamReader(ruta);
            //lee todo el archivo
            var texto = reader.ReadToEnd();
            //
            texto = texto.Replace("null","0");
            //obtenemos jsons
            var JsonArray = JsonConvert.DeserializeObject<Drug[]>(texto);
            //agregamos a la lista
            var ListaDrugs = new List<Drug>();
            //rename ctrl + r+r
            foreach (var Actual in JsonArray)
            {
                ListaDrugs.Add(Actual);
            }
            var ListaNombreID = new List<TreeNode>();
            foreach (var item in JsonArray)
            {
                var lel = new TreeNode
                {
                    Id = item.id,
                    Name = item.nombre
                };
                ListaNombreID.Add(lel);
            }
        }   
    }       
}           
