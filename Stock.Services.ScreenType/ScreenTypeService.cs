namespace Stock.Services.ScreenType
{ 
    using System.Collections.Generic;
    using BL.DtoEntities;

    public class ScreenTypeService : IScreenTypeService
    {
        private readonly BL.Services.Abstract.IScreenTypeService _screenTypeService;

        public ScreenTypeService()
        {
            _screenTypeService = new BL.Services.Concrete.ScreenTypeService();
        }

        public IEnumerable<ScreenTypeDto> GetAll()
        {
            return _screenTypeService.GetAll();
        }
    }
}
