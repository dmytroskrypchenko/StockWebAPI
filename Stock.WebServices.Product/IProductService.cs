namespace Stock.WebServices.Product
{
    using System.ServiceModel;
    using System.Collections.Generic;
    using BL.DtoEntities;

    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        void AddPhone(PhoneDto phone);

        [OperationContract]
        void AddElectronicBook(ElectronicBookDto electronicBook);

        [OperationContract]
        void AddSmartWatch(SmartWatchDto smartWatch);

        [OperationContract]
        IEnumerable<ProductDto> GetAllProducts();
    }
}
