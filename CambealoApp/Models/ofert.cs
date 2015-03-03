using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CambealoApp.Models
{
    public class ofert
    {
        [Key]
        public int ID { set; get; }
        public int IdOfferer { set; get; }
        public int IdChanger { set; get; }
        public string State { set; get; }
        public string type { set; get; }

        public virtual ICollection<User> user1 { get; set; }
        public virtual ICollection<User> user2 { get; set; }
    }
}