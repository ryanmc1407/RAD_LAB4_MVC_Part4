
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


 namespace RAD_LAB4_MVC.Models
{
    public class Category
    {
        public int ID { get; set; }
             
        public string Description { get; set; } = string.Empty;
 
        
        [ValidateNever]
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
