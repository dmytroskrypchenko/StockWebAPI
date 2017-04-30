namespace Stock.Services.Product
{
    using System.ServiceModel;
    using System.Collections.Generic;
    using BL.DtoEntities;

    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract(Name = "AddPhone")]
        void AddProduct(PhoneDto phone);

        [OperationContract(Name = "AddElectronicBook")]
        void AddProduct(ElectronicBookDto electronicBook);

        [OperationContract(Name = "AddSmartWatch")]
        void AddProduct(SmartWatchDto smartWatch);

        [OperationContract]
        void ImportProducts(FileDto file);

        [OperationContract]
        IEnumerable<ProductDto> GetAllProducts();
    }
}
