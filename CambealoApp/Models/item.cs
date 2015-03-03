using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CambealoApp.Models
{
    public class item
    {
        [Key]
        public int ID { set; get; }
        public int userID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string State { set; get; }
        public string prefer { set; get; }
        public string Image { set; get; }
        public DateTime Date { set; get; }

        public virtual ICollection<User> user { get; set; }

    }
}