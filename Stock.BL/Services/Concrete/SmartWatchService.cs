namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;

    public class SmartWatchService : BaseService<SmartWatch, SmartWatchDto>, ISmartWatchService
    {
        public SmartWatchService()
        {
            new SmartWatchMapperConfig().Configure();
        }
    }
}
