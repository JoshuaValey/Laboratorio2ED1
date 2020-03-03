using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2ED1.Helpers;
using Laboratorio2ED1.Models;
using Newtonsoft.Json;
using System.IO;

namespace Laboratorio2ED1.Controllers
{
    public class DrugController : Controller
    {
        public ActionResult Index()
        {
            /*string filepath = Console.ReadLine();
            StreamReader json = new StreamReader(filepath);
            string jsons = json.ReadToEnd();
            jsons = jsons.Replace("null", "0");
            Drug[] JsonArray = JsonConvert.DeserializeObject<Drug[]>(jsons);
            foreach(var item in JsonArray)
            {
                Storage.Instance.drugsList.Add(item);
            }*/

            //Farmacos de prueba. 
            Drug farmaco1 = new Drug
            {
                id = 1,
                descripcion = "Flsmdfr",
                nombre   = "Ositos de goma",
                precio = 45.23,
                casa_productora = "Similares",
                existencia = 30
            };
            Storage.Instance.drugsList.Add(farmaco1);
            Drug farmaco2 = new Drug
            {
                id = 2,
                descripcion = "Flsmdfr",
                nombre = "Ositos de goma",
                precio = 45.23,
                casa_productora = "Similares",
                existencia = 30
            };
            Storage.Instance.drugsList.Add(farmaco2);
            Drug farmaco3 = new Drug
            {
                id = 3,
                descripcion = "Flsmdfr",
                nombre = "Ositos de goma",
                precio = 45.23,
                casa_productora = "Similares",
                existencia = 30
            };
            Storage.Instance.drugsList.Add(farmaco3);

            Drug farmaco4 = new Drug
            {
                id = 4,
                descripcion = "Flsmdfr",
                nombre = "Ositos de goma",
                precio = 45.23,
                casa_productora = "Similares",
                existencia = 30
            };
            Storage.Instance.drugsList.Add(farmaco4);

            //Carga del json al comenzar el programa. 
            return View();
        }
        public ActionResult OrderList()
        {
            return View(Storage.Instance.drugsList);
        }
        public ActionResult DrugListOrder()
        {
            return View(Storage.Instance.OrderDrugList);
        }
        public ActionResult AddToCart(int id)
        {
            
            Storage.Instance.OrderDrugList.Add(Storage.Instance.drugsList.Find((drug) => {
                if (drug.id == id)
                    return true;
                else
                    return false;
            }));
            
            return View("OrderList", Storage.Instance.drugsList); ;
        }
        public ActionResult CreateOrder()
        {
            return View();
        }
        





        // GET: Drug/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Drug/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drug/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Drug/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Drug/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Drug/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Drug/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
