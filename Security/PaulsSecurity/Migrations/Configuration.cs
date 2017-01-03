using PaulsSecurity.Controllers;

namespace PaulsSecurity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PaulsSecurity.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PaulsSecurity.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PaulsSecurity.Models.ApplicationDbContext";
        }

        protected override void Seed(PaulsSecurity.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Customers.AddOrUpdate(
                  p => p.ID,
                  new Customer
                  {
                      File_As = "Power,Paul",
                      ID = 1,
                      Company = "Quest Software",
                      EmailAddress = "paul.power@quest.com",
                      MobilePhone = "0407 559 613"
                  },
                  new Customer {
                      File_As = "Robson,Dave",
                      ID = 2,
                      Company = "Quest Software",
                      EmailAddress = "david.robson@quest.com",
                      MobilePhone = "559 123 456"
                  }
                );
            
        }
    }
}
