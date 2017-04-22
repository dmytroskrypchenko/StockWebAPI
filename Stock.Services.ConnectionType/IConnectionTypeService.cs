namespace Stock.Services.ConnectionType
{
    using System.ServiceModel;
    using System.Collections.Generic;
    using BL.DtoEntities;

    [ServiceContract]
    public interface IConnectionTypeService
    {
        [OperationContract]
        IEnumerable<InterfaceForConnectingDto> GetAll();
    }
}
