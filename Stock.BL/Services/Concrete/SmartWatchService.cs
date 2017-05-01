namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;
    using ImportPipes.Concrete;
    using Repositories.Abstract;

    public class SmartWatchService : BaseService<SmartWatch, SmartWatchDto>, ISmartWatchService
    {
        public SmartWatchService()
        {
            new SmartWatchMapper().Configure();
        }
        public void Import(IDataRepository repository, FileDto file)
        {
            var excelData = new SmartWatchExcelDataCreator(file).Process();
            var smartWatchDtos = new SmartWatchDataParser(excelData, repository).Process();

            Insert(smartWatchDtos);
        }
    }
}
