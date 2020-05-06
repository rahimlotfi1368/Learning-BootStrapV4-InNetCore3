namespace Models
{
    public class ProductModel:Infrastructure.BaseEntity
    {
        public ProductModel():base()
        {

        }

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        public string Status { get; set; }
    }
}
