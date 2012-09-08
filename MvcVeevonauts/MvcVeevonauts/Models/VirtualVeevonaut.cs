using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcVeevonauts.Models
{
    public class VirtualVeevonaut
    {
        public int ID { get; set; }

        //[Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Type { get; set; }

        public int Intelligence { get; set; }

        public int Athleticism { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }

        public int Artistry { get; set; }

        public int ReactionTime { get; set; }
    }
}