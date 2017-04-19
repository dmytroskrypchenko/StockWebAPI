namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;

    public class PhoneService : BaseService<Phone, PhoneDto>, IPhoneService
    {
        public PhoneService()
        {
            new PhoneMapperConfig().Configure();
        }
    }
}
