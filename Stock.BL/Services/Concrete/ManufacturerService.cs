namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;

    public class ManufacturerService : BaseService<Manufacturer, ManufacturerDto>, IManufacturerService
    {
        public ManufacturerService()
        {
            new ManufacturerMapper().Configure();
        }
    }
}
