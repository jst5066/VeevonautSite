using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcVeevonauts.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string   SubType { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public string ItemArtUrl { get; set; }
        public ItemStyle Style { get; set; }
    }
}