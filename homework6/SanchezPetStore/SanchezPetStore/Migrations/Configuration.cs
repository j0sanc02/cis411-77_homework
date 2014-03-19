namespace SanchezPetStore.Migrations
{
    using SanchezPetStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SanchezPetStore.Models.AnimalDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SanchezPetStore.Models.AnimalDBContext";
        }

        protected override void Seed(SanchezPetStore.Models.AnimalDBContext context)
        {
            context.Animal.AddOrUpdate(i=>i.Name,

                new Animals
                {
                  Imagepath = "~/Content/Images/Boxer.jpg",
                  Name = "Susie",
                  Description = "The Boxer is a breed of stocky, medium-sized, short-haired dogs developed in Germany. Their coat is smooth and tight-fitting; colors are fawn or brindled, with or without white markings, which may cover the entire body, and white. Boxers are brachycephalic (they have broad, short skulls), have a square muzzle, mandibular prognathism (an underbite), very strong jaws, and a powerful bite ideal for hanging on to large prey. The Boxer was bred from the Old English Bulldog and the now extinct Bullenbeisser, and is part of the Molosser group.",
                  DateReceived = DateTime.Parse("2013-04-13"),
                  Quantity = 3,
                  Price = 1000.00M
                }
                        
              );            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
