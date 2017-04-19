namespace Stock.BL.Mapper.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class PhoneMapperConfig : IAutoMapperConfig
    {
        public void Configure()
        {
            AutoMapper.Mapper.CreateMap<Phone, PhoneDto>()
               .ForMember(d => d.Id, o => o.MapFrom(s => s.ProductId))
               .ForMember(d => d.PhoneId, o => o.MapFrom(s => s.Id))
               .ForMember(d => d.Name, o => o.MapFrom(s => s.Product.Name))
               .ForMember(d => d.Price, o => o.MapFrom(s => s.Product.Price))
               .ForMember(d => d.Description, o => o.MapFrom(s => s.Product.Description))
               .ForMember(d => d.Manufacturer, o => o.MapFrom(s => new ManufacturereDto { Id = s.Product.Manufacturer.Id, Name = s.Product.Manufacturer.Name }));

            AutoMapper.Mapper.CreateMap<PhoneDto, Phone>()
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
