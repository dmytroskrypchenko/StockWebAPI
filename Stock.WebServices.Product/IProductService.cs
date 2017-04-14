namespace Stock.WebServices.Product
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        string GetData(int value);
    }
}
