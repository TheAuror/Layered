using LayeredSolution.DataLayer.Schema;

namespace LayeredSolution.DataLayer.Migrations
{
    using BusinessLayer.Common;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LayeredSolution.DataLayer.SampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(LayeredSolution.DataLayer.SampleContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.Add(new Product
                {
                    ProductNo = "1234",
                    Name= "Android Phone",
                    Price = 1234,
                });
                context.Products.Add(new Product
                {
                    ProductNo = "2345",
                    Name = "Windows Phone",
                    Price = 2345
                });
                context.Products.Add(new Product
                {
                    ProductNo = "3456",
                    Name = "I Phone",
                    Price = 3456
                });
            }
            if (!context.Employees.Any(e => e.Role == "admin"))
            {
                context.Employees.Add(new EmployeeEntity
                {
                    Name = "Administrator",
                    UserName = "admin",
                    Password = PasswordHelper.EncryptPassword("admin"),
                    Position = "Administrator",
                    Role = "admin"
                });
            }
        }
    }
}
