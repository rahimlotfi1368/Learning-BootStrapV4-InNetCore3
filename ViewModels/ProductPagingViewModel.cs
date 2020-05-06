namespace ViewModels
{
    public class ProductPagingViewModel:object
    {
        public ProductPagingViewModel()
        {
            Paging = new cloudscribe.Web.Pagination.PaginationSettings();
        }
        public string Query { get; set; } = string.Empty;
        public System.Collections.Generic.List<Models.ProductModel> Products { get; set; } = null;
        public cloudscribe.Web.Pagination.PaginationSettings Paging { get; set; }
    }
}
