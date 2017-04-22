namespace Stock.Services.Manufacturer
{
    using System.ServiceModel;
    using System.Collections.Generic;
    using BL.DtoEntities;

    [ServiceContract]
    public interface IManufacturerService
    {
        [OperationContract]
        IEnumerable<ManufacturerDto> GetAll();
    }
}
