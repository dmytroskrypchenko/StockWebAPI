namespace Stock.BL.Mapper.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class ScreenTypeMapper : IMapper
    {
        public void Configure()
        {
            AutoMapper.Mapper.CreateMap<ScreenType, ScreenTypeDto>();

            AutoMapper.Mapper.CreateMap<ScreenTypeDto, ScreenType>();
        }
    }
}
