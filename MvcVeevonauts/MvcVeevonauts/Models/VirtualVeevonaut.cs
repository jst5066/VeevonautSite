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

        [Required(ErrorMessage = "Name is required")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type is required")]
        [StringLength(20)]
        public string Type { get; set; }

        [Required(ErrorMessage = "Intelligence is required")]
        [Range(1, 10000, ErrorMessage = 
            "Must be a value from 1 to 10000")]
        public int Intelligence { get; set; }

        [Required(ErrorMessage = "Athleticism is required")]
        [Range(1, 10000, ErrorMessage =
            "Must be a value from 1 to 10000")]
        public int Athleticism { get; set; }

        [Required(ErrorMessage = "Strength is required")]
        [Range(1, 10000, ErrorMessage =
            "Must be a value from 1 to 10000")]
        public int Strength { get; set; }

        [Required(ErrorMessage = "Speed is required")]
        [Range(1, 10000, ErrorMessage =
            "Must be a value from 1 to 10000")]
        public int Speed { get; set; }

        [Required(ErrorMessage = "Artistry is required")]
        [Range(1, 10000, ErrorMessage =
            "Must be a value from 1 to 10000")]
        public int Artistry { get; set; }

        [Required(ErrorMessage = "Reaction Time is required")]
        [Range(1, 10000, ErrorMessage =
            "Must be a value from 1 to 10000")]
        public int ReactionTime { get; set; }
    }
}