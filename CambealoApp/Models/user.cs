using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CambealoApp.Models
{
    public class User
    {
        [Key]
        public int ID { set; get; }
        public string Fullname { set; get; }
        public string Name { set; get; }
        [DataType(DataType.Password)]
        public string Password { set; get; }
        public string Mail { set; get; }
        public string Telephon { set; get; }
        public int Old { set; get; }

    }
}