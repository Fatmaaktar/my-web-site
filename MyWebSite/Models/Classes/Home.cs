using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models.Classes
{
    public class Home
    {
        [Key]
        public int id { get; set; }
        public string profil { get; set; }
        public string Name { get; set; }
        public string departmen { get; set; }
        public string explanation { get; set; }
        public string communication { get; set; }
    }
}