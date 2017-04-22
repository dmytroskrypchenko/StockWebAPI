namespace Stock.BL.Mapper.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    public class SmartWatchMapper : IMapper
    {
        public void Configure()
        {
            AutoMapper.Mapper.CreateMap<SmartWatch, SmartWatchDto>()
               .ForMember(d => d.Id, o => o.MapFrom(s => s.ProductId))
               .ForMember(d => d.SmartWatchId, o => o.MapFrom(s => s.Id))
               .ForMember(d => d.Name, o => o.MapFrom(s => s.Product.Name))
               .ForMember(d => d.Price, o => o.MapFrom(s => s.Product.Price))
               .ForMember(d => d.Description, o => o.MapFrom(s => s.Product.Description))
               .ForMember(d => d.Manufacturer, o => o.MapFrom(s => new ManufacturerDto { Id = s.Product.Manufacturer.Id, Name = s.Product.Manufacturer.Name }))
               .ForMember(d => d.InterfaceForConnecting, o => o.MapFrom(s => new InterfaceForConnectingDto { Id = s.InterfaceForConnecting.Id, Name = s.InterfaceForConnecting.Name }));

            AutoMapper.Mapper.CreateMap<SmartWatchDto, SmartWatch>()
                .ForMember(d => d.InterfaceForConnectingId, o => o.MapFrom(s => s.InterfaceForConnecting.Id))
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
