namespace Stock.BL.Services.Abstract
{
    using DtoEntities;
    using DAL;
    using Repositories.Abstract;
    using System.Collections.Generic;

    public interface IElectronicBookService : IBaseService<ElectronicBook, ElectronicBookDto>
    {
        void Import(IDataRepository repository, FileDto file);

        IEnumerable<ElectronicBookDto> GetForManufacturer(int idManufacturer);

        IEnumerable<ElectronicBookDto> GetForScreenType(int idScreenType);
    }
}
