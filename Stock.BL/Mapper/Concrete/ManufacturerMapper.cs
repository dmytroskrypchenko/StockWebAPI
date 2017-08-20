namespace Stock.BL.Mapper.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class ManufacturerMapper : IMapper<Manufacturer, ManufacturerDto>
    {
        public void Configure()
        {
            AutoMapper.Mapper.CreateMap<Manufacturer, ManufacturerDto>();

            AutoMapper.Mapper.CreateMap<ManufacturerDto, Manufacturer>();
        }
    }
}
