namespace Stock.BL.Services.Abstract
{
    using DtoEntities;
    using DAL;
    using Repositories.Abstract;
    using System.Collections.Generic;

    public interface IPhoneService : IBaseService<Phone, PhoneDto>
    {
        void Import(IDataRepository repository, FileDto file);

        IEnumerable<PhoneDto> GetForManufacturer(int idManufacturer, string orderDirection, string orderBy);
    }
}
