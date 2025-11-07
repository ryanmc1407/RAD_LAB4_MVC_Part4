namespace RAD_LAB4_MVC.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        
    }
}
