namespace Stock.BL.Services.Abstract
{
    using DtoEntities;
    using DAL;
    using Repositories.Abstract;

    public interface ISmartWatchService : IBaseService<SmartWatch, SmartWatchDto>
    {
        void Import(IDataRepository repository, FileDto file);
    }
}
