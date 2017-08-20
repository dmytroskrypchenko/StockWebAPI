namespace Stock.BL.Mapper.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class ConnectionTypeMapper : IMapper<InterfaceForConnecting, InterfaceForConnectingDto>
    {
        public void Configure()
        {
            AutoMapper.Mapper.CreateMap<InterfaceForConnecting, InterfaceForConnectingDto>();

            AutoMapper.Mapper.CreateMap<InterfaceForConnectingDto, InterfaceForConnecting>();
        }
    }
}
