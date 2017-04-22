namespace Stock.Services.TypeScreen
{
    using System.ServiceModel;
    using System.Collections.Generic;
    using BL.DtoEntities;

    [ServiceContract]
    public interface IScreenTypeService
    {
        [OperationContract]
        IEnumerable<ScreenTypeDto> GetAll();
    }
}
