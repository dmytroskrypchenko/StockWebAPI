namespace Stock.BL.Repositories.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DtoEntities;
    using Abstract;
    using Services.Abstract;

    public class DataRepository : IDataRepository
    {
        private readonly IManufacturerService _manufacturerService;
        private readonly IConnectionTypeService _connectionTypeService;
        private readonly IScreenTypeService _screenTypeService;

        private readonly Lazy<List<ManufacturerDto>> _manufacturers;
        private readonly Lazy<List<InterfaceForConnectingDto>> _connectionTypes;
        private readonly Lazy<List<ScreenTypeDto>> _screenTypes;

        public DataRepository(IManufacturerService manufacturerService, IConnectionTypeService connectionTypeService, IScreenTypeService screenTypeService)
        {
            _manufacturerService = manufacturerService;
            _connectionTypeService = connectionTypeService;
            _screenTypeService = screenTypeService;

            _manufacturers = new Lazy<List<ManufacturerDto>>(GetManufacturers);
            _connectionTypes = new Lazy<List<InterfaceForConnectingDto>>(GetConnectionTypes);
            _screenTypes = new Lazy<List<ScreenTypeDto>>(GetScreenTypes);
        }

        public List<ManufacturerDto> Manufacturers => _manufacturers.Value;
        public List<InterfaceForConnectingDto> ConectionTypes => _connectionTypes.Value;
        public List<ScreenTypeDto> ScreenTypes => _screenTypes.Value;

        private List<ManufacturerDto> GetManufacturers()
        {
            return _manufacturerService.GetAll().ToList();
        }

        private List<InterfaceForConnectingDto> GetConnectionTypes()
        {
            return _connectionTypeService.GetAll().ToList();
        }

        private List<ScreenTypeDto> GetScreenTypes()
        {
            return _screenTypeService.GetAll().ToList();
        }
    }
}