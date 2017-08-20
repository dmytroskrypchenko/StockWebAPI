namespace Stock.BL.Services.Concrete
{
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Abstract;
    using ImportPipes.Concrete;
    using Repositories.Abstract;
    using System.Collections.Generic;
    using System.Linq;
    using DAL.Infrastructure.Abstract;

    public class ElectronicBookService : BaseService<ElectronicBook, ElectronicBookDto>, IElectronicBookService
    {
        public ElectronicBookService(IUnitOfWorkFactory factory, IMapper<ElectronicBook, ElectronicBookDto> mapper)
            : base(factory, mapper)
        {
        }

        public void Import(IDataRepository repository, FileDto file)
        {
            var excelData = new ElectronicBookExcelDataCreator(file).Process();
            var electronicBookDtos = new ElectronicBookDataParser(excelData, repository).Process();

            Insert(electronicBookDtos);
        }

        public IEnumerable<ElectronicBookDto> GetForManufacturer(int idManufacturer)
        {
            using (var uow = _factory.Create())
            {
                var entitiesDto = new List<ElectronicBookDto>();
                var entities = uow.Repository<ElectronicBook>().Get(x => x.Product.ManufacturerId == idManufacturer).ToList();

                foreach (var item in entities)
                {
                    var entityDto = AutoMapper.Mapper.Map<ElectronicBookDto>(item);
                    entitiesDto.Add(entityDto);
                }

                return entitiesDto;
            }
        }

        public IEnumerable<ElectronicBookDto> GetForScreenType(int idScreenType)
        {
            using (var uow = _factory.Create())
            {
                var entitiesDto = new List<ElectronicBookDto>();
                var entities = uow.Repository<ElectronicBook>().Get(x => x.ScreenTypeId == idScreenType).ToList();

                foreach (var item in entities)
                {
                    var entityDto = AutoMapper.Mapper.Map<ElectronicBookDto>(item);
                    entitiesDto.Add(entityDto);
                }

                return entitiesDto;
            }
        }
    }
}