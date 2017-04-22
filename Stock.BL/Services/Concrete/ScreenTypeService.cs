namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;

    public class ScreenTypeService : BaseService<ScreenType, ScreenTypeDto>, IScreenTypeService
    {
        public ScreenTypeService()
        {
            new ScreenTypeMapper().Configure();
        }
    }
}
