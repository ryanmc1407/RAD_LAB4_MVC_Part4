using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace RAD_LAB4_MVC.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; } = string.Empty;
        public float UnitPrice { get; set; }
        public DateTime dateFirstIssued { get; set; }
        public int QuantityInStock { get; set; }
        
        [ValidateNever]
        public virtual Category? Category { get; set; }

        [ValidateNever]
        public ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }
}