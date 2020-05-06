namespace Infrastructure
{
    public static class Utility
    {
        static Utility()
        {

        }

        public static System.Collections.Generic.List<Models.ProductModel> GetProducts(int n)
        {
            var model = new System.Collections.Generic.List<Models.ProductModel>();
            for (int index = 1; index <= n; index++)
            {
                Models.ProductModel productModel =
                        new Models.ProductModel
                        {
                            Name = $"Product #{index}",
                            UnitPrice = 18 + index,
                            UnitsInStock = 56 + index,
                            Discontinued = (index % 2 == 0 ? true : false),
                            Status = (index % 2 == 0 ? "Fail" : "Success"),
                        };
                model.Add(productModel);
            }
                    
           return model;
        }

        
    }
}
