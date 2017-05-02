namespace Stock.BL.Services.Concrete
{
    using System;
    using DtoEntities;
    using Abstract;
    using DAL;
    using Mapper.Concrete;
    using ImportPipes.Concrete;
    using Repositories.Abstract;
    using System.Collections.Generic;
    using System.Linq;

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

        public IEnumerable<PhoneDto> GetForManufacturer(int idManufacturer, string orderDirection, string orderBy)
        {
            var orderExpression = buildOrderExpression(orderDirection, orderBy);
            using (var uow = _factory.Create())
            {
                var entitiesDto = new List<PhoneDto>();

                var entities = uow.Repository<Phone>().Get(x => x.Product.ManufacturerId == idManufacturer, orderExpression).ToList();

                foreach (var item in entities)
                {
                    var entityDto = AutoMapper.Mapper.Map<PhoneDto>(item);
                    entitiesDto.Add(entityDto);
                }

                return entitiesDto;
            }
        }

        private Func<IQueryable<Phone>, IOrderedQueryable<Phone>> buildOrderExpression(string orderDirection, string orderBy)
        {
            bool isOrderASC = orderDirection == "ASC";

            if (isOrderASC)
            {
                switch (orderBy)
                {
                    case "Price":
                        return query => query.OrderBy(b => b.Product.Price).ThenBy(b => b.Product.Name);
                    case "BatteryCapacity":
                        return query => query.OrderBy(b => b.BatteryCapacity).ThenBy(b => b.Product.Name);
                    case "ScreenDiagonal":
                        return query => query.OrderBy(b => b.ScreenDiagonal).ThenBy(b => b.Product.Name);
                    default:
                        break;
                }
            }
            else
            {
                switch (orderBy)
                {
                    case "Price":
                        return query => query.OrderByDescending(b => b.Product.Price).ThenByDescending(b => b.Product.Name);
                    case "BatteryCapacity":
                        return query => query.OrderByDescending(b => b.BatteryCapacity).ThenByDescending(b => b.Product.Name);
                    case "ScreenDiagonal":
                        return query => query.OrderByDescending(b => b.ScreenDiagonal).ThenByDescending(b => b.Product.Name);
                    default:
                        break;
                }
            }

            return query => query.OrderBy(b => b.Product.Name);
        }
    }
}
