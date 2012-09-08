using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcVeevonauts.Persistence;
using System.ComponentModel.DataAnnotations;

namespace MvcVeevonauts.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genre Must be Specified")]
        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Price is required")]
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        public decimal Price { get; set; }

        [StringLength(5)]
        public string Rating { get; set; }
    }
}