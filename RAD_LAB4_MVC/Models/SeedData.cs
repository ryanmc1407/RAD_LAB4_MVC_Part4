using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductModel;

namespace RAD_LAB4_MVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // If ANY products exist, do nothing
                if (context.Product.Any())
                {
                    return;
                }

                // ----- Create Categories -----
                var cat1 = new Category { Description = "Electronics" };
                var cat2 = new Category { Description = "Food" };
                var cat3 = new Category { Description = "Office" };

                // ----- Create Suppliers -----
                var sup1 = new Supplier
                {
                    SupplierName = "Super Supplies Ltd.",
                    AddressLine1 = "Main Street",
                    AddressLine2 = "Galway"
                };

                var sup2 = new Supplier
                {
                    SupplierName = "TechWarehouse",
                    AddressLine1 = "Industrial Park",
                    AddressLine2 = "Dublin"
                };

                // ----- Create Products -----
                var p1 = new Product
                {
                    Description = "Laptop",
                    QuantityInStock = 15,
                    UnitPrice = 999.99f,
                    Category = cat1
                };

                var p2 = new Product
                {
                    Description = "Printer Paper",
                    QuantityInStock = 500,
                    UnitPrice = 4.99f,
                    Category = cat3
                };

                var p3 = new Product
                {
                    Description = "Chocolate Bar",
                    QuantityInStock = 200,
                    UnitPrice = 1.50f,
                    Category = cat2
                };

                // ----- Many-to-Many setup -----
                p1.Suppliers.Add(sup2);  // TechWarehouse supplies Laptop
                p2.Suppliers.Add(sup1);  // Super Supplies supplies Paper
                p3.Suppliers.Add(sup1);  // Super Supplies supplies Chocolate

                // Add everything
                context.AddRange(cat1, cat2, cat3);
                context.AddRange(sup1, sup2);
                context.AddRange(p1, p2, p3);

                context.SaveChanges();
            }
        }

    }
}
