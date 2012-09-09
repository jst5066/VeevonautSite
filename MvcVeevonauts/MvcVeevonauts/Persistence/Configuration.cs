using System.Data.Entity.Migrations;
using MvcVeevonauts.Models;
using System.Linq;
using System.Collections.Generic;

namespace MvcVeevonauts.Persistence
{
    public class Configuration : DbMigrationsConfiguration<VeevonautsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(VeevonautsDBContext context)
        {
          
            var itemTypes = new List<ItemType> {
                new ItemType { Name = "Hat" },
                new ItemType { Name = "Jacket" }
            };

            var itemStyles = new List<ItemStyle>
            {
                new ItemStyle { Name = "Western" },
                new ItemStyle { Name = "Space" }
            };

            new List<Item>
            {
                new Item { SubType = "Cowboy Hat", Type = itemTypes.Single(
                    g => g.Name == "Hat"), Price = 1.00M, Style = itemStyles.Single(
                    a => a.Name == "Western"), 
                    ItemArtUrl = "/Content/Images/VeevonautItemPlaceholder.gif"},
                new Item { SubType = "Astronaut Jacket", Type = itemTypes.Single(
                    g => g.Name == "Jacket"), Price = 1.00M, Style = itemStyles.Single(
                    a => a.Name == "Space"), 
                    ItemArtUrl = "/Content/Images/VeevonautItemPlaceholder.gif"}
            }.ForEach(a => context.VeevonautItems.AddOrUpdate(i => new {i.SubType}, a));
            
        }
    }
}