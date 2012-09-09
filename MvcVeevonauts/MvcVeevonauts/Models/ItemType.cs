using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcVeevonauts.Models
{
    public class ItemType
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
    }
}