namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class SmartWatchService : BaseService<SmartWatch, SmartWatchDto>, ISmartWatchService
    {
    }
}
