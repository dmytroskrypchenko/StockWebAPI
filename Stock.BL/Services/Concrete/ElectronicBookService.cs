namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;
    using ImportPipes.Concrete;

    public class ElectronicBookService : BaseService<ElectronicBook, ElectronicBookDto>, IElectronicBookService
    {
        public ElectronicBookService()
        {
            new ElectronicBookMapper().Configure();
        }

        public void Import(FileDto file)
        {
            var excelData = new ElectronicBookExcelDataCreator(file).Process();
            var electronicBookDtos = new ElectronicBookDataParser(excelData).Process();

            Insert(electronicBookDtos);
        }
    }
}