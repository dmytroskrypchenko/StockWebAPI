namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;
    using ImportPipes.Concrete;
    using Repositories.Abstract;

    public class PhoneService : BaseService<Phone, PhoneDto>, IPhoneService
    {
        public PhoneService()
        {
            new PhoneMapper().Configure();
        }

        public void Import(IDataRepository repository, FileDto file)
        {
            var excelData = new PhoneExcelDataCreator(file).Process();
            var phoneDtos = new PhoneDataParser(excelData, repository).Process();

            Insert(phoneDtos);
        }
    }
}
