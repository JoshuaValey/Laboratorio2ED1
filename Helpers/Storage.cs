using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratorio2ED1.Models;
using CustomGenerics;

namespace Laboratorio2ED1.Helpers
{
    public class Storage { 
        private static Storage _instance = null;

        public static Storage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Storage();

                return _instance;
            }
        }

        public List<Order> shoppingCart = new List<Order>();
        public List<Drug> OrderDrugList = new List<Drug>();
        public List<DrugIndex> treeList = new List<DrugIndex>();


        //List from json
        public List<Drug> drugsList = new List<Drug>();
        public Order Bill = new Order();

        //arbol
        

    }
}