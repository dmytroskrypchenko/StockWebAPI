namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Abstract;
    using DAL.Infrastructure.Abstract;

    public class ScreenTypeService : BaseService<ScreenType, ScreenTypeDto>, IScreenTypeService
    {
        public ScreenTypeService(IUnitOfWorkFactory factory, IMapper<ScreenType, ScreenTypeDto> mapper)
            : base(factory, mapper)
        {
        }
    }
}
