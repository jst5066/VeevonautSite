using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcVeevonauts.Models
{
    public class Veevonaut
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
    }

    public class VeevonautDBContext : DbContext
    {
        public DbSet<Veevonaut> Veevonauts { get; set; }
    }
}