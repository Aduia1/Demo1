namespace CaffeMeoo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
 
    internal sealed class Configuration : DbMigrationsConfiguration<CaffeMeoo.Entities.CompanyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CaffeMeoo.Entities.CompanyDBContext";
        }

        protected override void Seed(CaffeMeoo.Entities.CompanyDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var adminUser = new Entities.MasterUser
            {
                Id = Guid.NewGuid().ToString(),
                Username = "admin",
                Password = BCrypt.Net.BCrypt.HashPassword("admin"),  // Mã hóa mật khẩu admin
                Fullname = "Administrator",
                Gender = "Male",
                PhoneNumber = "123456789",
                Email = "admin@domain.com",
                Position = "Admin",
                Birthday = "01/01/1990",
                RegistrationDate = DateTime.Now
            };

        }
    }
     
    }

