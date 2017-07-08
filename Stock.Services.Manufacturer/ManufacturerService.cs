namespace Stock.Services.Manufacturer
{
    using System.Collections.Generic;
    using BL.DtoEntities;

    public class ManufacturerService : IManufacturerService
    {
        private readonly BL.Services.Abstract.IManufacturerService _manufacturerService;

        public ManufacturerService(BL.Services.Abstract.IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        public IEnumerable<ManufacturerDto> GetAll()
        {
            return _manufacturerService.GetAll();
        }
    }
}
