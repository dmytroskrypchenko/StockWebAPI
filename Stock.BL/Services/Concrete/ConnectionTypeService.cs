namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Abstract;
    using DAL.Infrastructure.Abstract;

    public class ConnectionTypeService : BaseService<InterfaceForConnecting, InterfaceForConnectingDto>, IConnectionTypeService
    {
        public ConnectionTypeService(IUnitOfWorkFactory factory, IMapper<InterfaceForConnecting, InterfaceForConnectingDto> mapper)
            : base(factory, mapper)
        {
        }
    }
}
