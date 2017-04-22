namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;

    public class ConnectionTypeService : BaseService<InterfaceForConnecting, InterfaceForConnectingDto>, IConnectionTypeService
    {
        public ConnectionTypeService()
        {
            new ConnectionTypeMapper().Configure();
        }
    }
}
