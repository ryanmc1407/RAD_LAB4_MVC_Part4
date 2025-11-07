namespace RAD_LAB4_MVC.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public DateTime dateFirstIssued { get; set; }
        public int QuantityInStock { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Supplier> Suppliers { get; set; }
    }
}