namespace Stock.BL.Repositories.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DtoEntities;
    using Abstract;
    using Services.Concrete;

    public class DataRepository : IDataRepository
    {
        private readonly Lazy<List<ManufacturerDto>> _manufacturers;
        private readonly Lazy<List<InterfaceForConnectingDto>> _connectionTypes;
        private readonly Lazy<List<ScreenTypeDto>> _screenTypes;

        public DataRepository()
        {
            _manufacturers = new Lazy<List<ManufacturerDto>>(GetManufacturers);
            _connectionTypes = new Lazy<List<InterfaceForConnectingDto>>(GetConnectionTypes);
            _screenTypes = new Lazy<List<ScreenTypeDto>>(GetScreenTypes);
        }

        public List<ManufacturerDto> Manufacturers => _manufacturers.Value;
        public List<InterfaceForConnectingDto> ConectionTypes => _connectionTypes.Value;
        public List<ScreenTypeDto> ScreenTypes => _screenTypes.Value;

        private List<ManufacturerDto> GetManufacturers()
        {
            var manufacturerService = new ManufacturerService();
            return manufacturerService.GetAll().ToList();
        }

        private List<InterfaceForConnectingDto> GetConnectionTypes()
        {
            var connectionTypeService = new ConnectionTypeService();
            return connectionTypeService.GetAll().ToList();
        }

        private List<ScreenTypeDto> GetScreenTypes()
        {
            var screenTypeService = new ScreenTypeService();
            return screenTypeService.GetAll().ToList();
        }
    }
}