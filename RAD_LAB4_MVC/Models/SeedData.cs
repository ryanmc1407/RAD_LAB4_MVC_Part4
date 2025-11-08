using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RAD_LAB4_MVC.Data;

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

                // categories
                var laptops = new Category { Description = "Laptops" };
                var phones = new Category { Description = "Phones" };
                var office = new Category { Description = "Office" };
                context.Category.AddRange(laptops, phones, office);

                // suppliers
                var techWorld = new Supplier
                {
                    Name = "Tech World",
                    AddressLine1 = "123 Main St",
                    AddressLine2 = "Galway",
                    Products = new List<Product>()
                };

                var gadgetsLtd = new Supplier
                {
                    Name = "Gadgets Ltd",
                    AddressLine1 = "45 High St",
                    AddressLine2 = "Dublin",
                    Products = new List<Product>()
                };
                context.Supplier.AddRange(techWorld, gadgetsLtd);

                // products
                var p1 = new Product
                {
                    Description = "Dell XPS 13",
                    QuantityInStock = 12,
                    UnitPrice = 1299.99f,
                    dateFirstIssued = new DateTime(2024, 9, 1),
                    Category = laptops,
                    Suppliers = new List<Supplier> { techWorld }
                };

                var p2 = new Product
                {
                    Description = "iPhone 15",
                    QuantityInStock = 25,
                    UnitPrice = 1099.99f,
                    dateFirstIssued = new DateTime(2025, 1, 10),
                    Category = phones,
                    Suppliers = new List<Supplier> { gadgetsLtd }
                };

                var p3 = new Product
                {
                    Description = "Printer Paper (A4, 500)",
                    QuantityInStock = 400,
                    UnitPrice = 4.99f,
                    dateFirstIssued = new DateTime(2023, 6, 5),
                    Category = office,
                    Suppliers = new List<Supplier> { techWorld }
                };

                context.Product.AddRange(p1, p2, p3);
                context.SaveChanges();
            }
        }
    }
}