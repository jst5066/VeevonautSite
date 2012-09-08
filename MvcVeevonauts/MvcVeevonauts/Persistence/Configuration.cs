using System.Data.Entity.Migrations;
using MvcVeevonauts.Models;

namespace MvcVeevonauts.Persistence
{
    public class Configuration : DbMigrationsConfiguration<VeevonautsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}