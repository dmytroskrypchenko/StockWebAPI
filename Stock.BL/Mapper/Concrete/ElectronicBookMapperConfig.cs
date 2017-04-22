namespace Stock.BL.Mapper.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class ElectronicBookMapperConfig : IAutoMapperConfig
    {
        public void Configure()
        {
            AutoMapper.Mapper.CreateMap<ElectronicBook, ElectronicBookDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.ProductId))
                .ForMember(d => d.ElectronicBookId, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Product.Name))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Product.Price))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Product.Description))
                .ForMember(d => d.Manufacturer, o => o.MapFrom(s => new ManufacturerDto { Id = s.Product.Manufacturer.Id, Name = s.Product.Manufacturer.Name }))
                .ForMember(d => d.ScreenType, o => o.MapFrom(s => new ScreenTypeDto { Id = s.ScreenType.Id, Name = s.ScreenType.Name }));

            AutoMapper.Mapper.CreateMap<ElectronicBookDto, ElectronicBook>()
                .ForMember(d => d.ScreenTypeId, o => o.MapFrom(s => s.ScreenType.Id))
                .ForMember(d => d.Product, o => o.MapFrom(s => new Product
                {
                    Name = s.Name,
                    Price = s.Price,
                    Description = s.Description,
                    ManufacturerId = s.Manufacturer.Id
                }));
        }
    }
}
