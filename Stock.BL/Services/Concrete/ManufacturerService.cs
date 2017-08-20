namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Abstract;
    using DAL.Infrastructure.Abstract;

    public class ManufacturerService : BaseService<Manufacturer, ManufacturerDto>, IManufacturerService
    {
        public ManufacturerService(IUnitOfWorkFactory factory, IMapper<Manufacturer, ManufacturerDto> mapper)
            : base(factory, mapper)
        {
        }
    }
}
