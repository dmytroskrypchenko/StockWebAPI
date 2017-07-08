namespace Stock.Services.ConnectionType
{
    using System.Collections.Generic;
    using BL.DtoEntities;
    
    public class ConnectionTypeService : IConnectionTypeService
    {
        private readonly BL.Services.Abstract.IConnectionTypeService _connectionTypeService;

        public ConnectionTypeService(BL.Services.Abstract.IConnectionTypeService connectionTypeService)
        {
            _connectionTypeService = connectionTypeService;
        }

        public IEnumerable<InterfaceForConnectingDto> GetAll()
        {
            return _connectionTypeService.GetAll();
        }
    }
}
