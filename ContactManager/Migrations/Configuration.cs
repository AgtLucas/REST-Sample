namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ContactManager.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactManager.Models.ContactManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactManager.Models.ContactManagerContext context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
               new Contact
               {
                   Name = "Chuck Norris",
                   Address = "Unknow",
                   City = "Anywhere",
                   State = "WA",
                   Zip = "10999",
                   Email = "chuck@norris.com",
                   Twitter = "@norris"
               },
               new Contact { 
                   Name = "Elektra",
                   Address = "Thorsten Weinrich",
                   City = "Redmond",
                   State = "WA",
                   Zip = "192132",
                   Email = "hey@elektra.io",
                   Twitter = "@elektra"
               }
            );
        }
    }
}
