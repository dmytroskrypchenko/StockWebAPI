namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;

    public class ElectronicBookService : BaseService<ElectronicBook, ElectronicBookDto>, IElectronicBookService
    {
    }
}
