namespace Stock.Services.Manufacturer
{
    using System.Collections.Generic;
    using BL.DtoEntities;

    public class ManufacturerService : IManufacturerService
    {
        private readonly BL.Services.Abstract.IManufacturerService _manufacturerService;

        public ManufacturerService()
        {
            _manufacturerService = new BL.Services.Concrete.ManufacturerService();
        }

        public IEnumerable<ManufacturerDto> GetAll()
        {
            return _manufacturerService.GetAll();
        }
    }
}
