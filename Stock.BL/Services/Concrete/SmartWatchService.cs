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

    public class SmartWatchService : BaseService<SmartWatch, SmartWatchDto>, ISmartWatchService
    {
        public SmartWatchService(IUnitOfWorkFactory factory, IMapper<SmartWatch, SmartWatchDto> mapper)
            : base(factory, mapper)
        {
        }

        public void Import(IDataRepository repository, FileDto file)
        {
            var excelData = new SmartWatchExcelDataCreator(file).Process();
            var smartWatchDtos = new SmartWatchDataParser(excelData, repository).Process();

            Insert(smartWatchDtos);
        }

        public IEnumerable<SmartWatchDto> GetForManufacturer(int idManufacturer)
        {
            using (var uow = _factory.Create())
            {
                var entitiesDto = new List<SmartWatchDto>();
                var entities = uow.Repository<SmartWatch>().Get(x => x.Product.ManufacturerId == idManufacturer).ToList();

                foreach (var item in entities)
                {
                    var entityDto = AutoMapper.Mapper.Map<SmartWatchDto>(item);
                    entitiesDto.Add(entityDto);
                }

                return entitiesDto;
            }
        }

        public IEnumerable<SmartWatchDto> GetForConnectionType(int idInterfaceForConnection)
        {
            using (var uow = _factory.Create())
            {
                var entitiesDto = new List<SmartWatchDto>();
                var entities = uow.Repository<SmartWatch>().Get(x => x.InterfaceForConnectingId == idInterfaceForConnection).ToList();

                foreach (var item in entities)
                {
                    var entityDto = AutoMapper.Mapper.Map<SmartWatchDto>(item);
                    entitiesDto.Add(entityDto);
                }

                return entitiesDto;
            }
        }
    }
}
