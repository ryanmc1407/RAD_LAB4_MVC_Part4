using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RAD_LAB4_MVC.Models
{
    public class SupplierProduct
    {
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public DateTime DateFirstSupplied { get; set; }

        [ValidateNever]
        public virtual Supplier? FK_Supplier { get; set; }

        [ValidateNever]
        public virtual Product? FK_Product { get; set; }
    }
}