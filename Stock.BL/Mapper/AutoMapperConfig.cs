namespace Stock.BL.Mapper
{
    using DAL;
    using DtoEntities;

    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            ConfigurePhoneMapping();
            ConfigureSmartWatchMapping();
            ConfigureElectronicBookMapping();
        }

        private static void ConfigurePhoneMapping()
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

        private static void ConfigureSmartWatchMapping()
        {
            AutoMapper.Mapper.CreateMap<SmartWatch, SmartWatchDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.ProductId))
                .ForMember(d => d.SmartWatchId, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Product.Name))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Product.Price))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Product.Description))
                .ForMember(d => d.Manufacturer, o => o.MapFrom(s => new ManufacturereDto { Id = s.Product.Manufacturer.Id, Name = s.Product.Manufacturer.Name }))
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

        private static void ConfigureElectronicBookMapping()
        {
            AutoMapper.Mapper.CreateMap<ElectronicBook, ElectronicBookDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.ProductId))
                .ForMember(d => d.ElectronicBookId, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Product.Name))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Product.Price))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Product.Description))
                .ForMember(d => d.Manufacturer, o => o.MapFrom(s => new ManufacturereDto { Id = s.Product.Manufacturer.Id, Name = s.Product.Manufacturer.Name }))
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
