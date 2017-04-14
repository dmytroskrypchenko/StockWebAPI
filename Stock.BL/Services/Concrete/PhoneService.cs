namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class PhoneService : BaseService<Phone, PhoneDto>, IPhoneService
    {
    }
}
