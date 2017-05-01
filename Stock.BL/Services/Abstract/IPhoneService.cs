namespace Stock.BL.Services.Abstract
{
    using DtoEntities;
    using DAL;
    using Repositories.Abstract;

    public interface IPhoneService : IBaseService<Phone, PhoneDto>
    {
        void Import(IDataRepository repository, FileDto file);
    }
}
