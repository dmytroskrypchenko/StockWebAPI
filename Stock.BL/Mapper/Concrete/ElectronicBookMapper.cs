namespace Stock.BL.Mapper.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class ElectronicBookMapper : IMapper<ElectronicBook, ElectronicBookDto>
    {
        public void Configure()
        {
            AutoMapper.Mapper.CreateMap<ElectronicBook, ElectronicBookDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.ProductId))
                .ForMember(d => d.ElectronicBookId, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Product.Name))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Product.Price))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Product.Description))
                .ForMember(d => d.Manufacturer, o => o.MapFrom(s => s.Product.Manufacturer == null ? null : new ManufacturerDto
                {
                    Id = s.Product.Manufacturer.Id,
                    Name = s.Product.Manufacturer.Name
                }))
                .ForMember(d => d.ScreenType, o => o.MapFrom(s => s.ScreenType == null ? null : new ScreenTypeDto
                {
                    Id = s.ScreenType.Id,
                    Name = s.ScreenType.Name
                }));

            AutoMapper.Mapper.CreateMap<ElectronicBookDto, ElectronicBook>()
                .ForMember(d => d.ScreenTypeId, o => o.MapFrom(s => s.ScreenType == null ? default(int?) : s.ScreenType.Id))
                .ForMember(d => d.Product, o => o.MapFrom(s => new Product
                {
                    Name = s.Name,
                    Price = s.Price,
                    Description = s.Description,
                    ManufacturerId = s.Manufacturer == null ? default(int?) : s.Manufacturer.Id
                }));
        }
    }
}
