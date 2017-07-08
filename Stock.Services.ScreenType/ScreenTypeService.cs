namespace Stock.Services.ScreenType
{ 
    using System.Collections.Generic;
    using BL.DtoEntities;

    public class ScreenTypeService : IScreenTypeService
    {
        private readonly BL.Services.Abstract.IScreenTypeService _screenTypeService;

        public ScreenTypeService(BL.Services.Abstract.IScreenTypeService screenTypeService)
        {
            _screenTypeService = screenTypeService;
        }

        public IEnumerable<ScreenTypeDto> GetAll()
        {
            return _screenTypeService.GetAll();
        }
    }
}
