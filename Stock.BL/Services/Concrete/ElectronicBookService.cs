namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;
    using ImportPipes.Concrete;
    using Repositories.Abstract;

    public class ElectronicBookService : BaseService<ElectronicBook, ElectronicBookDto>, IElectronicBookService
    {
        public ElectronicBookService()
        {
            new ElectronicBookMapper().Configure();
        }

        public void Import(IDataRepository repository, FileDto file)
        {
            var excelData = new ElectronicBookExcelDataCreator(file).Process();
            var electronicBookDtos = new ElectronicBookDataParser(excelData, repository).Process();

            Insert(electronicBookDtos);
        }
    }
}