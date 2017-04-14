namespace Stock.WebServices.Product
{
    public class ProductService : IProductService
    {
        public string GetData(int value)
        {
            return $"You entered: {value}";
        }
    }
}
