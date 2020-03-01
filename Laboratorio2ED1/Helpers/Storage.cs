using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio2ED1.Helpers
{
    public class Storage
    {
        private Storage _instance = null;

        public Storage Instance
        {
            get
            {
                if (Instance == null) _instance = new Storage();
                return _instance;
            }

        }

    }
}