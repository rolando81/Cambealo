using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CambealoApp.Models
{
    public class ofert
    {
        public int ID { set; get; }
        public int IdOfferer { set; get; }
        public int IdChanger { set; get; }
        public string State { set; get; }
        public string type { set; get; }


    }
}