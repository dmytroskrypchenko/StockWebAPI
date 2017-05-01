namespace Stock.BL.Services.Abstract
{
    using DtoEntities;
    using DAL;
    using Repositories.Abstract;

    public interface IElectronicBookService : IBaseService<ElectronicBook, ElectronicBookDto>
    {
        void Import(IDataRepository repository, FileDto file);
    }
}
