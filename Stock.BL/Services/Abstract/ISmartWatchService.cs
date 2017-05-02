namespace Stock.BL.Services.Abstract
{
    using DtoEntities;
    using DAL;
    using Repositories.Abstract;
    using System.Collections.Generic;

    public interface ISmartWatchService : IBaseService<SmartWatch, SmartWatchDto>
    {
        void Import(IDataRepository repository, FileDto file);

        IEnumerable<SmartWatchDto> GetForManufacturer(int idManufacturer);

        IEnumerable<SmartWatchDto> GetForConnectionType(int idInterfaceForConnection);
    }
}
