using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RAD_LAB4_MVC.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;

        [ValidateNever]
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
